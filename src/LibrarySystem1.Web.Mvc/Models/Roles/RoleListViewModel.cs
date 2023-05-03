using System.Collections.Generic;
using LibrarySystem1.Roles.Dto;

namespace LibrarySystem1.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
