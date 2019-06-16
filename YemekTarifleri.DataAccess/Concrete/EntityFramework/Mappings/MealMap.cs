using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MealMap:EntityTypeConfiguration<Meal>
    {
        public MealMap()
        {
            ToTable(@"Meal", @"dbo");
            HasKey(x=>x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.CookingTime).HasColumnName("CookingTime");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            Property(x => x.Image).HasColumnName("Image");
            Property(x => x.PersonQuantity).HasColumnName("PersonQuantity");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Point).HasColumnName("Point");
            Property(x => x.PreparationTime).HasColumnName("PreparationTime");
        }
    }
}
