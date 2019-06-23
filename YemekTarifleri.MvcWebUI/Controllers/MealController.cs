using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Core.Aspects.Postsharp.AuthorizationAspects;
using YemekTarifleri.Entities.Concrete;
using YemekTarifleri.MvcWebUI.Models;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    [SecuredOperation(Roles = "Admin")]
    public class MealController : Controller
    {
        private IMealService _mealService;
        private ICategoryService _categoryService;

        public MealController(IMealService mealService,ICategoryService categoryService)
        {
            _mealService = mealService;
            _categoryService = categoryService;
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
            MealViewModel model=new MealViewModel
            {
                Categories = new SelectList(_categoryService.GetAll(),"Id","CategoryName").ToList(),
                Meal = new Meal()

            };
            return View(model);
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

        public ActionResult Delete(int id)
        {
            var meal = _mealService.GetById(id);

            if (System.IO.File.Exists(Server.MapPath(meal.Image)))
            {
                System.IO.File.Delete(Server.MapPath(meal.Image));
            }
            _mealService.Delete(meal);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var meal = _mealService.GetById(id);
            MealViewModel model=new MealViewModel
            {
                Categories = new SelectList(_categoryService.GetAll(),"Id","CategoryName"),
                Meal = meal
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Meal meal,HttpPostedFileBase image,string currentImage)
        {
            if (image != null)
            {
                if (System.IO.File.Exists(Server.MapPath(meal.Image)))
                {
                    System.IO.File.Delete(Server.MapPath(meal.Image));
                }

                WebImage img = new WebImage(image.InputStream);
                FileInfo imgInfo = new FileInfo(image.FileName);

                string newImage = Guid.NewGuid().ToString() + imgInfo.Extension;
                img.Resize(800, 350);
                img.Save("~/Uploads/Meal/" + newImage);
                meal.Image = "/Uploads/Meal/" + newImage;
            }
            _mealService.Update(meal);
            return RedirectToAction("Index");
        }
    }
}