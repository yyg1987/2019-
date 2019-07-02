using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace YJ.PF.Web.Views
{
    public abstract class PFRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PFRazorPage()
        {
            LocalizationSourceName = PFConsts.LocalizationSourceName;
        }
    }
}
