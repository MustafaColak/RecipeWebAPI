using Newtonsoft.Json;
using Recipes.BLL;
using Recipes.Entity.Model;
using Recipes.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace Recipes.WebAPI.Controllers
{
    public class HomeController : ApiController
    {

        RecipeController _rc;
        CategoryController _cc;
        RecipeCategoryController _rcc;
        public HomeController()
        {
            _rc = new RecipeController();
            _cc = new CategoryController();
            _rcc = new RecipeCategoryController();
        }


        /******************Story 2****************/

        [Route("services/recipe/filter/categories")]
        public IHttpActionResult Gett()
        {
            CategoryModel cm = new CategoryModel();

            try
            {
                //DB'den kategorilerin isimlerini çek
                var category = _cc.GetByExp().Select(x => x.Name).ToList();
                cm.Categories = category;
                cm.Results = category.Count;
                //Yoksa NoContent geri döndür
                if (cm.Results == 0)
                {
                    return StatusCode(HttpStatusCode.NoContent);
                }

                return Ok(cm);
            }
            catch { }

            return StatusCode(HttpStatusCode.InternalServerError);
        }

        /******************Story 1****************/

        [Route("services/recipe/filter/all")]
        [HttpPost]
        public IHttpActionResult All(Recipe recipe)
        {
            try
            {
                List<Recipe> recipes = _rc.GetByExp().Where(x => x.Title == recipe.Title).ToList();

                //Gelen title ın DB de olup olmadığı kontrolü
                if (recipes.Count() == 0)
                {
                    return StatusCode(HttpStatusCode.NoContent);
                }

                ResultModel resultModel = new ResultModel();
                resultModel.recipes = recipes; //Aranan Tarif Listeleri
                resultModel.results = recipes.Count(); //Aranan tarif sayısı
                resultModel.total = _rc.GetByExp().Count(); // DB'de kayıtlı tarif sayısı

                return Ok(resultModel);
            }
            catch { }

            return StatusCode(HttpStatusCode.InternalServerError);
        }


        /******************Story 3****************/
        [Route("services/recipe/filter/add")]
        [HttpPost]
        public IHttpActionResult Add(RecipeModel recipeModel)
        {
            try
            {
                //Gelen json formatının kontrolü
                if (!ModelState.IsValid)
                {
                    return StatusCode(HttpStatusCode.BadRequest);
                }
                else
                {
                    //Gelen tarif DB'ye kaydetme
                    Recipe recipe = new Recipe();
                    recipe.Directions = recipeModel.directions;
                    recipe.Ingredients = recipeModel.ingredients;
                    recipe.Title = recipeModel.title;
                    _rc.Add(recipe);


                    //Kategoriler string listesi şeklinde geldiği için tek tek içinde dönmek gerek
                    foreach (var item in recipeModel.categories)
                    {
                        //Gelen kategori ismi daha önce DB'de var mı yok mu kontrolü
                        Category category = _cc.GetByExp().Where(x => x.Name == item).FirstOrDefault();

                        RecipeCategory rc = new RecipeCategory();

                        if (category == null)
                        {
                            //Yoksa kategori tablosuna kaydedilir.
                            Category ctgry = new Category();
                            ctgry.Name = item;
                            _cc.Add(ctgry);

                            //Tarifin Id'si ve kaydettiğimiz kategorinin Id'sini ara tabloya ekleme
                            rc.RecipeId = recipe.Id;
                            rc.CategoryId = ctgry.Id;
                            _rcc.Add(rc);
                        }
                        else
                        {
                            //Kategori önceden DB'de varsa Id'si alınıp Tarif Id'si ile ara tabloya kaydetme
                            rc.RecipeId = recipe.Id;
                            rc.CategoryId = category.Id;
                            _rcc.Add(rc);
                        }
                    }

                    return StatusCode(HttpStatusCode.Created);

                }
            }
            catch { }

            return StatusCode(HttpStatusCode.InternalServerError);

        }
    }
}
