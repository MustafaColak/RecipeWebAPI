using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.WebAPI.Models
{
    public class ResultModel
    {
        public int results { get; set; }
        public int total { get; set; }
        public List<Recipe> recipes { get; set; }
    }
}