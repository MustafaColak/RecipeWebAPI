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
    public class CategoryRepository : ICategoryRepository
    {
        private RecipesDBContext context;
        public CategoryRepository()
        {
            context = new RecipesDBContext();
        }

        public void Add(Category entity)
        {
            context.Categories.Add(entity);
            Save();
        }
        public List<Category> Get(Expression<Func<Category, bool>> exp = null)
        {
            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.Categories.SingleOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
