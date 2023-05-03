using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibrarySystem1.Controllers
{
    public abstract class LibrarySystem1ControllerBase: AbpController
    {
        protected LibrarySystem1ControllerBase()
        {
            LocalizationSourceName = LibrarySystem1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
