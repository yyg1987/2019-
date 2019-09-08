using YJ.PF.Sessions.Dto;

namespace YJ.PF.Web.Areas.Mpa.Models.Layout
{
    public class FooterViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public bool UseWrapperDiv { get; set; }

        public string GetProductNameWithEdition()
        {
            const string productName = "PF";

            if (LoginInformations.Tenant == null)
            {
                return productName;
            }

            return productName; //+ " " + LoginInformations.Tenant.Edition.DisplayName;
        }
    }
}