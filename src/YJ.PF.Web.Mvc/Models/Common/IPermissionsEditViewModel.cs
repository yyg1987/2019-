using System.Collections.Generic;
using YJ.PF.Roles.Dto;

namespace YJ.PF.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}