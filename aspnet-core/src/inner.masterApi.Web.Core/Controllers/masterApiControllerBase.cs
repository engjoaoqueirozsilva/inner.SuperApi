using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace inner.masterApi.Controllers
{
    public abstract class masterApiControllerBase: AbpController
    {
        protected masterApiControllerBase()
        {
            LocalizationSourceName = masterApiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
