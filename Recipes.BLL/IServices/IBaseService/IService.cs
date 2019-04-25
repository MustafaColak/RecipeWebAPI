using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.BLL.IServices.IBaseService
{
    public interface IService<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        List<TEntity> GetByExp(Expression<Func<TEntity, bool>> exp = null);
        TEntity GetById(TKey id);
        string Add(TEntity entity);
    }
}
