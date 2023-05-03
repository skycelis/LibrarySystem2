using System.Threading.Tasks;
using Abp.Application.Services;
using LibrarySystem2.Sessions.Dto;

namespace LibrarySystem2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
