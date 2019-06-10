using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.DataAccess;
using YemekTarifleri.Core.Entities;
using YemekTarifleri.Entities.ComplexTypes;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
