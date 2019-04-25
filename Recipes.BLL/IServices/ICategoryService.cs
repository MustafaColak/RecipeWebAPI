using Recipes.BLL.IServices.IBaseService;
using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.BLL.IServices
{
    public interface ICategoryService : IService<Category, int>
    {
    }
}
