using YJ.PF.Sessions.Dto;
using Abp.Extensions;

namespace YJ.PF.Web.Areas.Mpa.Models.Layout
{
    public class LogoViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public string LogoSkinOverride { get; set; }

        public string GetLogoUrl(string appPath, string logoSkin)
        {
            if (!LogoSkinOverride.IsNullOrEmpty())
            {
                logoSkin = LogoSkinOverride;
            }
            return appPath + $"Common/Images/app-logo-on-{logoSkin}.svg";

            //if (LoginInformations?.Tenant?.LogoId == null)
            //{
            //    return appPath + $"Common/Images/app-logo-on-{logoSkin}.svg";
            //}

            ////id parameter is used to prevent caching only.
            //return appPath + "TenantCustomization/GetLogo?id=" + LoginInformations.Tenant.LogoId;
        }
    }
}
