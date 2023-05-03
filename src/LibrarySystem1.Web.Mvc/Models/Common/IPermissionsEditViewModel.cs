using System.Collections.Generic;
using LibrarySystem1.Roles.Dto;

namespace LibrarySystem1.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}