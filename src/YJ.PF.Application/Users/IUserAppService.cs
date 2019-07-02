using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YJ.PF.Roles.Dto;
using YJ.PF.Users.Dto;

namespace YJ.PF.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
