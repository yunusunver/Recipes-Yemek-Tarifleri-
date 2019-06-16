using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
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
            return View();
        }
    }
}