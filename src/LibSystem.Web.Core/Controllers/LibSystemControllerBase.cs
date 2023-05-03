using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibSystem.Controllers
{
    public abstract class LibSystemControllerBase: AbpController
    {
        protected LibSystemControllerBase()
        {
            LocalizationSourceName = LibSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
