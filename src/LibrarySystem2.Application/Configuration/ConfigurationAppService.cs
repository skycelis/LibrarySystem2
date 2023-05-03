using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibrarySystem2.Configuration.Dto;

namespace LibrarySystem2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibrarySystem2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
