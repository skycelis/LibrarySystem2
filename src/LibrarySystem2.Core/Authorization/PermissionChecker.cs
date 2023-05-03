using Abp.Authorization;
using LibrarySystem2.Authorization.Roles;
using LibrarySystem2.Authorization.Users;

namespace LibrarySystem2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
