using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem1.Roles.Dto;
using LibrarySystem1.Users.Dto;

namespace LibrarySystem1.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
