using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.MvcWebUI.Models
{
    public class MealViewModel
    {
        public List<Meal> Meals { get; set; }
        public Meal Meal { get; set; }
    }
}