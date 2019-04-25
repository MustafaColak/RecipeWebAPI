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
    public class DirectionsController : IDirectionsService
    {
        DirectionsRepository _directionsRepository;
        public DirectionsController()
        {
            _directionsRepository = new DirectionsRepository();
        }
        public string Add(Directions entity)
        {
            _directionsRepository.Add(entity);
            return "Adding Successful";
        }

        public List<Directions> GetByExp(Expression<Func<Directions, bool>> exp = null)
        {
            return _directionsRepository.Get();
        }

        public Directions GetById(int id)
        {
            return _directionsRepository.GetById(id);
        }
    }
}
