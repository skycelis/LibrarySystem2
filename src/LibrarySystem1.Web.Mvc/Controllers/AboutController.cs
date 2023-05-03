﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LibrarySystem1.Controllers;

namespace LibrarySystem1.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LibrarySystem1ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
