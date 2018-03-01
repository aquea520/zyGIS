using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace zyGIS.Controllers
{
    public abstract class zyGISControllerBase: AbpController
    {
        protected zyGISControllerBase()
        {
            LocalizationSourceName = zyGISConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
