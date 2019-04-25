using Recipes.BLL.IServices;
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
    public class RecipeCategoryController : IRecipeCategoryService
    {
        RecipeCategoryRepository _recipeCategoryRepository;
        public RecipeCategoryController()
        {
            _recipeCategoryRepository = new RecipeCategoryRepository();
        }

        public string Add(RecipeCategory entity)
        {
            _recipeCategoryRepository.Add(entity);
            return "Adding Successful";
        }

        public List<RecipeCategory> GetByExp(Expression<Func<RecipeCategory, bool>> exp = null)
        {
            return _recipeCategoryRepository.Get();
        }

        public List<RecipeCategory> GetRecipeCategories(int id)
        {
            return _recipeCategoryRepository.GetRecipeCategories(id);
        }

        public RecipeCategory GetById(int id)
        {
            return _recipeCategoryRepository.GetById(id);
        }
    }
}
