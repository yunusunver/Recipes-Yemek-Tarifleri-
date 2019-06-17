using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.MvcWebUI.Models;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService _categoryService;

        private IUserService _userService;

        private IMealService _mealService;

        public HomeController(ICategoryService categoryService, IUserService userService, IMealService mealService)
        {
            _categoryService = categoryService;
            _userService = userService;
            _mealService = mealService;
        }


        // GET: Home
        public ActionResult Index()
        {
            var model = new HomeViewModel
            {
                Categories = _categoryService.GetAll(),
                Meals = _mealService.GetAll()
            };
            return View(model);
        }
    }
}