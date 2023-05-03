using System.Threading.Tasks;
using Abp.Application.Services;
using LibrarySystem1.Sessions.Dto;

namespace LibrarySystem1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
