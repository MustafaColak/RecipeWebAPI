using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace Recipes.Entity.Model
{
    
    public class Directions : IEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Step { get; set; }
    }
}
