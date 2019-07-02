using Abp.Authorization;
using YJ.PF.Authorization.Roles;
using YJ.PF.Authorization.Users;

namespace YJ.PF.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
