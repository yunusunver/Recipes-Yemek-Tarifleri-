using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Abstract
{
    public interface IUserRoleService
    {
        UserRole Get(Expression<Func<UserRole,bool>> filter);
        UserRole Add(UserRole userRole);
        UserRole Update(UserRole userRole);
    }
}
