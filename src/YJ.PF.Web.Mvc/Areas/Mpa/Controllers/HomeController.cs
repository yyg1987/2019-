using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.MultiTenancy;
using Microsoft.AspNetCore.Mvc;
using YJ.PF.Authorization;
using YJ.PF.Controllers;
using YJ.PF.Web.Controllers;

namespace YJ.PF.Web.Areas.Mpa.Controllers
{
    [Area("Mpa")]
    [AbpMvcAuthorize]
    public class HomeController : PFControllerBase
    {
        //public async Task<ActionResult> Index()
        //{
        //    if (AbpSession.MultiTenancySide == MultiTenancySides.Host)
        //    {
        //        if (await IsGrantedAsync(AppPermissions.Pages_Administration_Host_Dashboard))
        //        {
        //            return RedirectToAction("Index", "HostDashboard");
        //        }

        //        if (await IsGrantedAsync(AppPermissions.Pages_Tenants))
        //        {
        //            return RedirectToAction("Index", "Tenants");
        //        }
        //    }
        //    else
        //    {
        //        if (await IsGrantedAsync(AppPermissions.Pages_Tenant_Dashboard))
        //        {
        //            return RedirectToAction("Index", "Dashboard");
        //        }
        //    }

        //    //Default page if no permission to the pages above
        //    return RedirectToAction("Index", "Welcome");
        //}


        public ActionResult Index()
        {
            return View();
        }

    }
}