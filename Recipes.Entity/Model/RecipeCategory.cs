using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Entity.Model
{
    public class RecipeCategory : IEntity
    {
        [Key]
        [Column(Order = 1)]
        public int RecipeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CategoryId { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual Category Category { get; set; }
    }
}
