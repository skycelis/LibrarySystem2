using Abp.AutoMapper;
using LibrarySystem2.Roles.Dto;
using LibrarySystem2.Web.Models.Common;

namespace LibrarySystem2.Web.Models.Roles
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
