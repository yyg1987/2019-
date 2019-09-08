using Abp.Application.Navigation;

namespace YJ.PF.Web.Areas.Mpa.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}