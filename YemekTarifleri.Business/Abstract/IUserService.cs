using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Entities.ComplexTypes;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName,string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
