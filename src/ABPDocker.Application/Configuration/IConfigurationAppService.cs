using System.Threading.Tasks;
using ABPDocker.Configuration.Dto;

namespace ABPDocker.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
