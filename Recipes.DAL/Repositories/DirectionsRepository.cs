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
    public class DirectionsRepository : IDirectionsRepository
    {
        private RecipesDBContext context;
        public DirectionsRepository()
        {
            context = new RecipesDBContext();
        }

        public void Add(Directions entity)
        {
            context.Directions.Add(entity);
            Save();
        }

        public List<Directions> Get(Expression<Func<Directions, bool>> exp = null)
        {
            return context.Directions.ToList();
        }

        public Directions GetById(int id)
        {
            return context.Directions.SingleOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
