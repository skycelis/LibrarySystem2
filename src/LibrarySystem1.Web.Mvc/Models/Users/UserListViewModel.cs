using System.Collections.Generic;
using LibrarySystem1.Roles.Dto;

namespace LibrarySystem1.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
