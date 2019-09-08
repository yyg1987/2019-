using System.Collections.Generic;
using YJ.PF.Authorization.Permissions.Dto;

namespace YJ.PF.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}