using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPDocker.MultiTenancy.Dto;

namespace ABPDocker.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

