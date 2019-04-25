using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.WebAPI.Models
{
    public class CategoryModel
    {
        public int Results { get; set; }
        public List<string> Categories { get; set; }
    }
}