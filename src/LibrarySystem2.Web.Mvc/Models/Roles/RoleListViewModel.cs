using System.Collections.Generic;
using LibrarySystem2.Roles.Dto;

namespace LibrarySystem2.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
