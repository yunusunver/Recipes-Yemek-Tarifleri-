using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.DataAccess.Concrete.EntityFramework.Mappings;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.EntityFramework
{
    public class FoodContext:DbContext
    {
        public FoodContext()
        {
            Database.SetInitializer<FoodContext>(null);
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
