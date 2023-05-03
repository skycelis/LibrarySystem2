﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LibSystem.Web.Views
{
    public abstract class LibSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LibSystemRazorPage()
        {
            LocalizationSourceName = LibSystemConsts.LocalizationSourceName;
        }
    }
}
