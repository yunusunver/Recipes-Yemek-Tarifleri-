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
            return _mealDal.GetAllMeal();
            
        }

        public Meal GetById(int id)
        {
            return _mealDal.GetMeal(x => x.Id == id);
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
