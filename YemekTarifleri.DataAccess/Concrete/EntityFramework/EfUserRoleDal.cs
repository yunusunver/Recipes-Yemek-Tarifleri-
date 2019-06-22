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
    public class EfUserRoleDal:EfEntityRepositoryBase<UserRole,FoodContext>,IUserRoleDal
    {
        public UserRole GetUserRole(Expression<Func<UserRole, bool>> filter)
        {
            using (var context = new FoodContext())
            {
                return context.UserRoles.Include("User").Include("Role").SingleOrDefault(filter);
            }
        }
    }
}
