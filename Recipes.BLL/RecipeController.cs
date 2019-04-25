using Recipes.BLL.IServices;
using Recipes.DAL.IRepository;
using Recipes.DAL.Repositories;
using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.BLL
{
    public class RecipeController : IRecipeService
    {
        RecipeRepository _recipeRepository;
        public RecipeController()
        {
            _recipeRepository = new RecipeRepository();
        }


        public string Add(Recipe entity)
        {
            _recipeRepository.Add(entity);
            return "Adding Successful";
        }

        public List<Recipe> GetByExp(Expression<Func<Recipe, bool>> exp = null)
        {
            return _recipeRepository.Get();
        }

        public Recipe GetById(int id)
        {
            return _recipeRepository.GetById(id);
        }

        public List<Category> GetCategory(int id)
        {
            return _recipeRepository.GetCategory(id);
        }
    }
}
