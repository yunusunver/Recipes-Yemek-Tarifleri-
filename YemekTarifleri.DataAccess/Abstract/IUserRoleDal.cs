using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Core.DataAccess;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Abstract
{
    public interface IUserRoleDal:IEntityRepository<UserRole>
    {
        UserRole GetUserRole(Expression<Func<UserRole,bool>> filter);
    }
}
