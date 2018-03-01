using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using zyGIS.Configuration;

namespace zyGIS.Web.Host.Startup
{
    [DependsOn(
       typeof(zyGISWebCoreModule))]
    public class zyGISWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public zyGISWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(zyGISWebHostModule).GetAssembly());
        }
    }
}
