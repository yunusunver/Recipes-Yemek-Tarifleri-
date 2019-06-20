using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.Entities;

namespace YemekTarifleri.Entities.Concrete
{
    public class Category:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string CategoryName { get; set; }

        public virtual List<Meal> Meal { get; set; }

        public Category()
        {
            Meal = new List<Meal>();
        }

    }
}
