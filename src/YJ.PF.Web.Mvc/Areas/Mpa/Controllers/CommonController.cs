using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using YJ.PF.Controllers;
using YJ.PF.Web.Areas.Mpa.Models.Common.Modals;
using YJ.PF.Web.Controllers;

namespace YJ.PF.Web.Areas.Mpa.Controllers
{
    [Area("Mpa")]
    [AbpMvcAuthorize]
    public class CommonController : PFControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }

        public PartialViewResult EntityTypeHistoryModal(EntityHistoryModalViewModel input)
        {
            return PartialView("Modals/_EntityTypeHistoryModal", ObjectMapper.Map<EntityHistoryModalViewModel>(input));
        }
    }
}