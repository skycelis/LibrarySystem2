using System.Collections.Generic;
using LibSystem.Roles.Dto;

namespace LibSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
