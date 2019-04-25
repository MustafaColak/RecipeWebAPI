using Recipes.DAL.IRepository;
using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Recipes.DAL.Repositories
{
    public class RecipeCategoryRepository : IRecipeCategoryRepository
    {
        private RecipesDBContext context;
        public RecipeCategoryRepository()
        {
            context = new RecipesDBContext();
        }

        public void Add(RecipeCategory entity)
        {
            context.RecipeCategories.Add(entity);
            Save();
        }

        public List<RecipeCategory> Get(Expression<Func<RecipeCategory, bool>> exp = null)
        {
            return context.RecipeCategories.Include(x=>x.Category).ToList();
        }

        public List<RecipeCategory> GetRecipeCategories(int id)
        {
            return context.RecipeCategories.Include(x => x.Category).Where(x => x.RecipeId == id).ToList();
        }

        public RecipeCategory GetById(int id)
        {
            return context.RecipeCategories.SingleOrDefault(x => x.RecipeId == id);
            
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
