using Recipes.DAL.IRepository;
using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private RecipesDBContext context;
        public IngredientRepository()
        {
            context = new RecipesDBContext();
        }

        public void Add(Ingredient entity)
        {
            context.Ingredients.Add(entity);
            Save();
        }

        public List<Ingredient> Get(Expression<Func<Ingredient, bool>> exp = null)
        {
            return context.Ingredients.ToList();
        }

        public Ingredient GetById(int id)
        {
            return context.Ingredients.SingleOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
