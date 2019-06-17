using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.MvcWebUI.Models
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Meal> Meals { get; set; }
        public List<User> Users { get; set; }
    }
}