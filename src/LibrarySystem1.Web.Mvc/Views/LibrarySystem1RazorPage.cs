using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LibrarySystem1.Web.Views
{
    public abstract class LibrarySystem1RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LibrarySystem1RazorPage()
        {
            LocalizationSourceName = LibrarySystem1Consts.LocalizationSourceName;
        }
    }
}
