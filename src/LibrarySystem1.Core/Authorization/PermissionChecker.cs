using Abp.Authorization;
using LibrarySystem1.Authorization.Roles;
using LibrarySystem1.Authorization.Users;

namespace LibrarySystem1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
