using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Role", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.Name).HasColumnName("Name");
        }
    }
}
