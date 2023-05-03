using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LibrarySystem2.Web.Views
{
    public abstract class LibrarySystem2RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LibrarySystem2RazorPage()
        {
            LocalizationSourceName = LibrarySystem2Consts.LocalizationSourceName;
        }
    }
}
