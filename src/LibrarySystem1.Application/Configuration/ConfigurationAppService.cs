using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibrarySystem1.Configuration.Dto;

namespace LibrarySystem1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibrarySystem1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
