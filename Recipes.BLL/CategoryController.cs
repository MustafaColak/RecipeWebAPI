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
    public class CategoryController : ICategoryService
    {
        CategoryRepository _categoryRepository;
        public CategoryController()
        {
            _categoryRepository = new CategoryRepository();
        }

        public string Add(Category entity)
        {
            _categoryRepository.Add(entity);
            return "Adding Successful";
        }

        public List<Category> GetByExp(Expression<Func<Category, bool>> exp = null)
        {
            return _categoryRepository.Get();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }
    }
}
