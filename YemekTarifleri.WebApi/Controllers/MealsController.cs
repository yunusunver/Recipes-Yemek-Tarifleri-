using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.WebApi.Controllers
{
    public class MealsController : ApiController
    {
        private IMealService _mealService;

        public MealsController(IMealService mealService)
        {
            _mealService = mealService;
        }

        public List<Meal> Get()
        {
            return _mealService.GetAll();
        }
    }
}
