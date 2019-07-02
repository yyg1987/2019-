using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using YJ.PF.Configuration.Dto;

namespace YJ.PF.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PFAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
