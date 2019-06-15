using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Abstract
{
    public interface IMealService
    {
        List<Meal> GetAll();
        Meal GetById(int id);
        Meal Add(Meal meal);
        Meal Update(Meal meal);
        void Delete(Meal meal);
    }
}
