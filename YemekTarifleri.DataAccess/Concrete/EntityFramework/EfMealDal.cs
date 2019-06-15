using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.DataAccess.EntityFramework;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.EntityFramework
{
    public class EfMealDal:EfEntityRepositoryBase<Meal,FoodContext>,IMealDal
    {
    }
}
