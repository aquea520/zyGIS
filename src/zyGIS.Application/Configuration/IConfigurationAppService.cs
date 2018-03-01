using System.Threading.Tasks;
using zyGIS.Configuration.Dto;

namespace zyGIS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
