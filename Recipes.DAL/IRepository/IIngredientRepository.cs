using Recipes.DAL.IRepository.IBaseRepository;
using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.IRepository
{
    interface IIngredientRepository : IRepository<Ingredient, int>
    {
    }
}
