using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using YJ.PF.Controllers;

namespace YJ.PF.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PFControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
