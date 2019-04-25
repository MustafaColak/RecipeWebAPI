using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.IRepository.IBaseRepository
{
    public interface IRepository<TEntity, TKey> :
        IAdd<TEntity>,
        IGetById<TEntity, TKey>,
        IGetByExp<TEntity>,
        ISave
        where TEntity : class, IEntity, new()
    {
    }
}
