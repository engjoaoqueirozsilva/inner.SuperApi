using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using inner.masterApi.Configuration;

namespace inner.masterApi.Web.Host.Startup
{
    [DependsOn(
       typeof(masterApiWebCoreModule))]
    public class masterApiWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public masterApiWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(masterApiWebHostModule).GetAssembly());
        }
    }
}
