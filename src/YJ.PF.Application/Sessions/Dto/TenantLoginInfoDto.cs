using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using YJ.PF.MultiTenancy;

namespace YJ.PF.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
