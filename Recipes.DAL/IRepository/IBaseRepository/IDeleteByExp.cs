using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.IRepository.IBaseRepository
{
    public interface IDeleteByExp<TEntity> where TEntity : class, IEntity, new()
    {
        int Delete(Expression<Func<TEntity, bool>> exp);
    }
}
