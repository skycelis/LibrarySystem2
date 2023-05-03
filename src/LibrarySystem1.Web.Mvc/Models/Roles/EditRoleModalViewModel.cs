using Abp.AutoMapper;
using LibrarySystem1.Roles.Dto;
using LibrarySystem1.Web.Models.Common;

namespace LibrarySystem1.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
