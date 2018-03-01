using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using zyGIS.Configuration;
using zyGIS.Web;

namespace zyGIS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class zyGISDbContextFactory : IDesignTimeDbContextFactory<zyGISDbContext>
    {
        public zyGISDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<zyGISDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            zyGISDbContextConfigurer.Configure(builder, configuration.GetConnectionString(zyGISConsts.ConnectionStringName));

            return new zyGISDbContext(builder.Options);
        }
    }
}
