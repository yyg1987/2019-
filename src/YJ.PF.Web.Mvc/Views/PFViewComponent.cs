using Abp.AspNetCore.Mvc.ViewComponents;

namespace YJ.PF.Web.Views
{
    public abstract class PFViewComponent : AbpViewComponent
    {
        protected PFViewComponent()
        {
            LocalizationSourceName = PFConsts.LocalizationSourceName;
        }
    }
}
