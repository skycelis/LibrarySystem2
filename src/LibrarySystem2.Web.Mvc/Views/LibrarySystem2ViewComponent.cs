using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibrarySystem2.Web.Views
{
    public abstract class LibrarySystem2ViewComponent : AbpViewComponent
    {
        protected LibrarySystem2ViewComponent()
        {
            LocalizationSourceName = LibrarySystem2Consts.LocalizationSourceName;
        }
    }
}
