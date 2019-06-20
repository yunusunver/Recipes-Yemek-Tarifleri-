using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.DataAccess.EntityFramework;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.EntityFramework
{
    public class EfMealDal:EfEntityRepositoryBase<Meal,FoodContext>,IMealDal
    {
        public List<Meal> GetAllMeal()
        {
            using (var context=new FoodContext())
            {
                return context.Meals.Include("Category").Include("User").ToList();
            }
        }

        public Meal GetMeal(Expression<Func<Meal, bool>> filter)
        {
            using (var context = new FoodContext())
            {
                return context.Meals.Include("Category").Include("User").SingleOrDefault(filter);
            }
        }
    }
}
