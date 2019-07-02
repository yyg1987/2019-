using System.Threading.Tasks;
using Abp.Application.Services;
using YJ.PF.Authorization.Accounts.Dto;

namespace YJ.PF.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
