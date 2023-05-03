using System.Threading.Tasks;
using LibSystem.Configuration.Dto;

namespace LibSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
