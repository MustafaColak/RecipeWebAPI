using Recipes.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DAL
{
    class RecipesDBContext : DbContext
    {

        private static RecipesDBContext _context;

       internal static RecipesDBContext Context
        {
            get
            {
                if(_context == null)
                {
                    _context = new RecipesDBContext();
                }
                return _context;
            }
        }

        public DbSet<Amount> Amounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Directions> Directions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }

        //Tablo isimlerinin sonundaki "s" leri silmek için
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
