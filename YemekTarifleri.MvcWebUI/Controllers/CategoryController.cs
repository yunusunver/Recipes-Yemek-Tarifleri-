using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Entities.Concrete;
using YemekTarifleri.MvcWebUI.Models;

namespace YemekTarifleri.MvcWebUI.Controllers
{
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
        public ActionResult Create(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var findCategory = _categoryService.GetById(id);
            return View(findCategory);
        }

        [HttpPost]
        public ActionResult Update(Category category)
        {
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