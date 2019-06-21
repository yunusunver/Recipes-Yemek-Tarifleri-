using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.ComplexTypes;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(x=>x.UserName==userName & x.Password==password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }
    }
}
