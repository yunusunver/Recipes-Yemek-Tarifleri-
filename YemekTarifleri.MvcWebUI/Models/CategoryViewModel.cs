using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.MvcWebUI.Models
{
    public class CategoryViewModel
    {
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
        public List<User> Users { get; set; }
        public Meal Meal { get; set; }
    }
}