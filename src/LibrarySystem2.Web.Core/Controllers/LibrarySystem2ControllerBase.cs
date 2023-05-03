using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibrarySystem2.Controllers
{
    public abstract class LibrarySystem2ControllerBase: AbpController
    {
        protected LibrarySystem2ControllerBase()
        {
            LocalizationSourceName = LibrarySystem2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
