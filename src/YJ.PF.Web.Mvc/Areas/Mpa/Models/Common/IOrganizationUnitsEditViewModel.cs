using System.Collections.Generic;
using YJ.PF.Organizations.Dto;

namespace YJ.PF.Web.Areas.Mpa.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}