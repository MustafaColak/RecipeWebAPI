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
    public class AmountController : IAmountService
    {
        AmountRepository _amountRepository;
        public AmountController()
        {
            _amountRepository = new AmountRepository();
        }

        public string Add(Amount entity)
        {
            _amountRepository.Add(entity);
            return "Adding Successful";
        }

        public List<Amount> GetByExp(Expression<Func<Amount, bool>> exp = null)
        {
            return _amountRepository.Get();
        }

        public Amount GetById(int id)
        {
            return _amountRepository.GetById(id);
        }
    }
}
