using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Business.ValidationRules.FluentValidation;
using YemekTarifleri.Core.Aspects.Postsharp;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Concrete.Managers
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }
        [FluentValidationAspect(typeof(CategoryValidator))]
        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        [FluentValidationAspect(typeof(CategoryValidator))]
        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }
    }
}
