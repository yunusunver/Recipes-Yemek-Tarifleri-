using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Entities.Concrete;
using YemekTarifleri.MvcWebUI.Models;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    public class MealController : Controller
    {
        private IMealService _mealService;

        public MealController(IMealService mealService)
        {
            _mealService = mealService;
        }

        // GET: Meal
        public ActionResult Index()
        {
            var model = new MealViewModel
            {
                Meals=_mealService.GetAll()
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Meal meal,HttpPostedFileBase image)
        {
            if (image != null)
            {
                WebImage img = new WebImage(image.InputStream);
                FileInfo imgInfo = new FileInfo(image.FileName);

                string newImage = Guid.NewGuid().ToString() + imgInfo.Extension;
                img.Resize(800, 350);
                img.Save("~/Uploads/Meal/" + newImage);
                meal.Image = "/Uploads/Meal/"+newImage;
            }
            _mealService.Add(meal);
            return RedirectToAction("Index");
        }
    }
}