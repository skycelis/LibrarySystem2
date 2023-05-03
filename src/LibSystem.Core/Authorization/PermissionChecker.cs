using Abp.Authorization;
using LibSystem.Authorization.Roles;
using LibSystem.Authorization.Users;

namespace LibSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
