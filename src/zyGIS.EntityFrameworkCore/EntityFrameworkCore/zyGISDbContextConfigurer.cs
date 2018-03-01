using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace zyGIS.EntityFrameworkCore
{
    public static class zyGISDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<zyGISDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<zyGISDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
