using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Entity.Model
{
    
    public class Amount : IEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
    }
}
