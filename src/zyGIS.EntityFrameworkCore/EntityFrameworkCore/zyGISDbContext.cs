using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using zyGIS.Authorization.Roles;
using zyGIS.Authorization.Users;
using zyGIS.MultiTenancy;

namespace zyGIS.EntityFrameworkCore
{
    public class zyGISDbContext : AbpZeroDbContext<Tenant, Role, User, zyGISDbContext>
    {
        /* Define a DbSet for each entity of the application */ 
		public virtual DbSet<zyGIS.TableConfigs.TableConfig> TableConfigs { get; set; }
		public virtual DbSet<zyGIS.Peoples.People> Peoples { get; set; }
        public virtual DbSet<zyGIS.Form.Form> Forms { get; set; }

        public zyGISDbContext(DbContextOptions<zyGISDbContext> options)
            : base(options)
        {
        }
    }
}
