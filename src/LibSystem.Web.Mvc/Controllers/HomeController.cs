using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LibSystem.Controllers;

namespace LibSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LibSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
