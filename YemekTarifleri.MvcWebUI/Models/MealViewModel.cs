using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.MvcWebUI.Models
{
    public class MealViewModel
    {
        public List<Meal> Meals { get; set; }
        public Meal Meal { get; set; }
        public Category Category { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; }
    }
}