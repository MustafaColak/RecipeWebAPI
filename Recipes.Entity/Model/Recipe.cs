using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Entity.Model
{
    public class Recipe : IEntity
    {
        public Recipe()
        {
           // Categories = new List<Category>();
            Ingredients = new List<Ingredient>();
        }

        [JsonIgnore]
        public int Id { get; set; }
        public string Title { get; set; }
        //public List<Category> Categories { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Directions Directions { get; set; }
    }
}
