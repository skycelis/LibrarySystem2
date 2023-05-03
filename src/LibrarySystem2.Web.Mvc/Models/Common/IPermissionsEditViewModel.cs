using System.Collections.Generic;
using LibrarySystem2.Roles.Dto;

namespace LibrarySystem2.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}