using System.Threading.Tasks;
using YJ.PF.Configuration.Dto;

namespace YJ.PF.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
