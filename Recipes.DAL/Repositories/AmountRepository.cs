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
    public class AmountRepository : IAmountRepository
    {
        private RecipesDBContext context;
        public AmountRepository()
        {
            context = new RecipesDBContext();
        }

        public void Add(Amount entity)
        {
            context.Amounts.Add(entity);
            Save();
        }

        public List<Amount> Get(Expression<Func<Amount, bool>> exp = null)
        {
            return context.Amounts.ToList();
        }

        public Amount GetById(int id)
        {
            return context.Amounts.SingleOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
