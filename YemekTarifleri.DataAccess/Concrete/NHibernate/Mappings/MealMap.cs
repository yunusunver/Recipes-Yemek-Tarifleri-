using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.NHibernate.Mappings
{
    public class MealMap:ClassMap<Meal>
    {
        public MealMap()
        {
            Table(@"Meal");
            LazyLoad();
            Id(x => x.Id).Column("Id");
            Map(x => x.CategoryId).Column("CategoryId");
            Map(x => x.UserId).Column("UserId");
            Map(x => x.CookingTime).Column("CookingTime");
            Map(x => x.Description).Column("Description");
            Map(x => x.CreatedDate).Column("CreatedDate");
            Map(x => x.Image).Column("Image");
            Map(x => x.PersonQuantity).Column("PersonQuantity");
            Map(x => x.Name).Column("Name");
            Map(x => x.Point).Column("Point");
            Map(x => x.PreparationTime).Column("PreparationTime");
        }
    }
}
