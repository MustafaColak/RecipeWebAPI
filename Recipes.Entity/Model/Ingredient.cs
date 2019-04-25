using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Entity.Model
{
    public class Ingredient : IEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        public Amount Amount { get; set; }
        public string Name { get; set; }
    }
}
