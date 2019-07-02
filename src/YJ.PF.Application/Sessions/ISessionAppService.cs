using System.Threading.Tasks;
using Abp.Application.Services;
using YJ.PF.Sessions.Dto;

namespace YJ.PF.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
