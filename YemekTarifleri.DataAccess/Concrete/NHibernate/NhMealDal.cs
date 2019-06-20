using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.DataAccess.NHibernate;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.NHibernate
{
    public class NhMealDal:NhEntityRepositoryBase<Meal>,IMealDal
    {
        public NhMealDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }

        public List<Meal> GetAllMeal()
        {
            throw new NotImplementedException();
        }

        public Meal GetMeal(Expression<Func<Meal, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
