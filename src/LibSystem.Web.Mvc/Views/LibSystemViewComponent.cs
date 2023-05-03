using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibSystem.Web.Views
{
    public abstract class LibSystemViewComponent : AbpViewComponent
    {
        protected LibSystemViewComponent()
        {
            LocalizationSourceName = LibSystemConsts.LocalizationSourceName;
        }
    }
}
