using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace YJ.PF.Controllers
{
    public abstract class PFControllerBase: AbpController
    {
        protected PFControllerBase()
        {
            LocalizationSourceName = PFConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
