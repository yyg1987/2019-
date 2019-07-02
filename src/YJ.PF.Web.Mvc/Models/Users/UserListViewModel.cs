using System.Collections.Generic;
using YJ.PF.Roles.Dto;
using YJ.PF.Users.Dto;

namespace YJ.PF.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
