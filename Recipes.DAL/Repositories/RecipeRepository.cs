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
    public class RecipeRepository : IRecipeRepository
    {
        private RecipesDBContext context;
        public RecipeRepository()
        {
            context = new RecipesDBContext();
        }
       

        public void Add(Recipe entity)
        {
            context.Recipes.Add(entity);
            Save();
            
                        
        }

        public List<Recipe> Get(Expression<Func<Recipe, bool>> exp = null)
        {
            return context.Recipes.Include(x => x.Directions).Include(x=>x.Ingredients).ToList();
        }

        public List<Category> GetCategory(int id)
        {
            //return context.Set<Recipe>().Where(x => x.Id == id).SelectMany(x => x.Categories).ToList();
            return context.Categories.ToList();

        }

        public Recipe GetById(int id)
        {
            return context.Recipes.SingleOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
