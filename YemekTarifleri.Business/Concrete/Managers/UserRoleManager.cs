using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Concrete.Managers
{
    public class UserRoleManager:IUserRoleService
    {
        private IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }

        public UserRole Get(Expression<Func<UserRole, bool>> filter)
        {
            return _userRoleDal.GetUserRole(filter);
        }

        public UserRole Add(UserRole userRole)
        {
            return _userRoleDal.Add(userRole);
        }

        public UserRole Update(UserRole userRole)
        {
            return _userRoleDal.Update(userRole);
        }
    }
}
