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
    public class IngredientController : IIngredientService
    {
        IngredientRepository _ingredientRepository;
        public IngredientController()
        {
            _ingredientRepository = new IngredientRepository();
        }

        public string Add(Ingredient entity)
        {
            _ingredientRepository.Add(entity);
            return "Adding Successful";
        }

        public List<Ingredient> GetByExp(Expression<Func<Ingredient, bool>> exp = null)
        {
            return _ingredientRepository.Get();
        }

        public Ingredient GetById(int id)
        {
            return _ingredientRepository.GetById(id);
        }
    }
}
