using System.Threading.Tasks;
using LibrarySystem2.Configuration.Dto;

namespace LibrarySystem2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
