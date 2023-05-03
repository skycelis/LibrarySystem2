﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LibrarySystem2.Controllers;

namespace LibrarySystem2.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LibrarySystem2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
