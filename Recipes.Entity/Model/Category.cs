using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Entity.Model
{
    public class Category : IEntity
    {
        public Category()
        {
            //Recipe = new List<Recipe>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
       // public List<Recipe> Recipe { get; set; }/
    }
}
