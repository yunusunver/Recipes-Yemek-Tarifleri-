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
        }
    }
}
