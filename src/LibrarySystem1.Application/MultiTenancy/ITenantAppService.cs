using Abp.Application.Services;
using LibrarySystem1.MultiTenancy.Dto;

namespace LibrarySystem1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

