using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YJ.PF.MultiTenancy.Dto;

namespace YJ.PF.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

