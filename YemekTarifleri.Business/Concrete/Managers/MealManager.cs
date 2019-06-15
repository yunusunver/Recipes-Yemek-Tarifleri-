using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Concrete.Managers
{
    public class MealManager:IMealService
    {
        private IMealDal _mealDal;
        private readonly IMapper _mapper;

        public MealManager(IMealDal mealDal,IMapper mapper)
        {
            _mealDal = mealDal;
            _mapper = mapper;
        }

        public List<Meal> GetAll()
        {
            var meals = _mapper.Map<List<Meal>>(_mealDal.GetList());
            return meals;
        }

        public Meal GetById(int id)
        {
            return _mealDal.Get(x => x.Id == id);
        }

        public Meal Add(Meal meal)
        {
            return _mealDal.Add(meal);
        }

        public Meal Update(Meal meal)
        {
            return _mealDal.Update(meal);
        }

        public void Delete(Meal meal)
        {
             _mealDal.Delete(meal);
        }
    }
}
