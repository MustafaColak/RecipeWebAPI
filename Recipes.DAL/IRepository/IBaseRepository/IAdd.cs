using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL.IRepository.IBaseRepository
{
    public interface IAdd<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
    }
}
