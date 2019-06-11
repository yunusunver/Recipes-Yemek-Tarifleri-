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
    public class CategoriesController : ApiController
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> Get()
        {
            return _categoryService.GetAll();
        }
    }
}
