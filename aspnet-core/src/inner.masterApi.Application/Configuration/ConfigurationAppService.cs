using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using inner.masterApi.Configuration.Dto;

namespace inner.masterApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : masterApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
