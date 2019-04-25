using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.IRepository.IBaseRepository
{
    public interface IGetByExp<TEntity> where TEntity: class, new()
    {
        List<TEntity> Get(Expression<Func<TEntity, bool>> exp = null);
    }
}
