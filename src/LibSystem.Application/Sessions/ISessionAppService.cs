using System.Threading.Tasks;
using Abp.Application.Services;
using LibSystem.Sessions.Dto;

namespace LibSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
