using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibrarySystem1.Web.Views
{
    public abstract class LibrarySystem1ViewComponent : AbpViewComponent
    {
        protected LibrarySystem1ViewComponent()
        {
            LocalizationSourceName = LibrarySystem1Consts.LocalizationSourceName;
        }
    }
}
