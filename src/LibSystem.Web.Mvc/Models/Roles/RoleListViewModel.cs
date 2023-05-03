using System.Collections.Generic;
using LibSystem.Roles.Dto;

namespace LibSystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
