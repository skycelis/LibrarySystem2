using System.Collections.Generic;
using LibrarySystem2.Roles.Dto;

namespace LibrarySystem2.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
