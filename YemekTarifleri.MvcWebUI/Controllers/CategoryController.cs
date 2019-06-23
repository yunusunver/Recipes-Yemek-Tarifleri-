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
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var model = new CategoryViewModel
            {
                Categories=_categoryService.GetAll()
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category,HttpPostedFileBase image)
        {
            if (image != null)
            {
                WebImage img = new WebImage(image.InputStream);
                FileInfo imgInfo = new FileInfo(image.FileName);

                string newImage = Guid.NewGuid().ToString() + imgInfo.Extension;
                img.Resize(800, 350);
                img.Save("~/Uploads/Category/" + newImage);
                category.Image = "/Uploads/Category/" + newImage;
            }
            _categoryService.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var findCategory = _categoryService.GetById(id);
            return View(findCategory);
        }

        [HttpPost]
        public ActionResult Update(Category category,HttpPostedFileBase image)
        {
            if (image != null)
            {
                if (System.IO.File.Exists(Server.MapPath(category.Image)))
                {
                    System.IO.File.Delete(Server.MapPath(category.Image));
                }

                WebImage img = new WebImage(image.InputStream);
                FileInfo imgInfo = new FileInfo(image.FileName);

                string newImage = Guid.NewGuid().ToString() + imgInfo.Extension;
                img.Resize(800, 350);
                img.Save("~/Uploads/Category/" + newImage);
                category.Image = "/Uploads/Category/" + newImage;
            }
            _categoryService.Update(category);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var findCategory = _categoryService.GetById(id);
            _categoryService.Delete(findCategory);
            return RedirectToAction("Index");
        }
    }
}