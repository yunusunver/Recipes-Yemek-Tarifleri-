using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using YemekTarifleri.Core.Entities;

namespace YemekTarifleri.Entities.Concrete
{
    public class Meal:IEntity
    {
        public virtual int Id { get; set; }
        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        [ForeignKey("Category")]
        public virtual int  CategoryId { get; set; }
        public virtual string Name { get; set; }
        [AllowHtml]
        public virtual string Description { get; set; }
        public virtual string CookingTime { get; set; }
        public virtual string PersonQuantity { get; set; }
        public virtual string PreparationTime { get; set; }
        public virtual string Point { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string Image { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
