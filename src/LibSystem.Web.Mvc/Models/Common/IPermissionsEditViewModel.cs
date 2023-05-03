using System.Collections.Generic;
using LibSystem.Roles.Dto;

namespace LibSystem.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}