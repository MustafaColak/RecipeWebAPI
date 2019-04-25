using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.WebAPI.Models
{
    public class RecipeModel
    {
        public string title { get; set; }
        public List<string> categories { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public Directions directions { get; set; }
    }
}