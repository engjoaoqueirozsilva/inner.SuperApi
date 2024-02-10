using Abp.Application.Services;
using inner.masterApi.MultiTenancy.Dto;

namespace inner.masterApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

