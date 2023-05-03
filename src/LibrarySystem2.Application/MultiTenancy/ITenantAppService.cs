using Abp.Application.Services;
using LibrarySystem2.MultiTenancy.Dto;

namespace LibrarySystem2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

