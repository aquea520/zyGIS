using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using zyGIS.Authorization;

namespace zyGIS
{
    [DependsOn(
        typeof(zyGISCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class zyGISApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<zyGISAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(zyGISApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
