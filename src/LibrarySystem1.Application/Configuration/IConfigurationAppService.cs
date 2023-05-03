using System.Threading.Tasks;
using LibrarySystem1.Configuration.Dto;

namespace LibrarySystem1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
