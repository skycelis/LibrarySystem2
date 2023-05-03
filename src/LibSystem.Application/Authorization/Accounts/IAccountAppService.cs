using System.Threading.Tasks;
using Abp.Application.Services;
using LibSystem.Authorization.Accounts.Dto;

namespace LibSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
