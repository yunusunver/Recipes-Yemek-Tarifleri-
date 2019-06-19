using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Business.ValidationRules.FluentValidation;
using YemekTarifleri.Core.Aspects.Postsharp;
using YemekTarifleri.Core.Aspects.Postsharp.AuthorizationAspects;
using YemekTarifleri.Core.Aspects.Postsharp.CacheAspects;
using YemekTarifleri.Core.Aspects.Postsharp.LogAspects;
using YemekTarifleri.Core.Aspects.Postsharp.ValidationAspects;
using YemekTarifleri.Core.CrossCuttingConcerns.Caching.Microsoft;
using YemekTarifleri.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using YemekTarifleri.Core.Utilities.Mapping;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;


namespace YemekTarifleri.Business.Concrete.Managers
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal,IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        [CacheAspect(typeof(MemoryCacheManager),60)]
        //[SecuredOperation(Roles = "Admin")]
        public List<Category> GetAll()
        {
            var categories = _mapper.Map<List<Category>>(_categoryDal.GetList());
            return categories;
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }
        [FluentValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        [FluentValidationAspect(typeof(CategoryValidator))]
        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
