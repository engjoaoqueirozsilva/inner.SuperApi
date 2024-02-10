using System.Threading.Tasks;
using inner.masterApi.Configuration.Dto;

namespace inner.masterApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
