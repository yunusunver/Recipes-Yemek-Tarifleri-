using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.DataAccess.EntityFramework;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.ComplexTypes;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,FoodContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (var context=new FoodContext())
            {
                var result = from ur in context.UserRoles
                    join r in context.Roles
                    on ur.UserId equals user.Id
                    where ur.UserId == user.Id
                    select new UserRoleItem{RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
