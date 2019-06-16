using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.Entities;

namespace YemekTarifleri.Entities.Concrete
{
    public class Meal:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int  CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CookingTime { get; set; }
        public string PersonQuantity { get; set; }
        public string PreparationTime { get; set; }
        public string Point { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }

    }
}
