using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using inner.masterApi.Authorization;

namespace inner.masterApi
{
    [DependsOn(
        typeof(masterApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class masterApiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<masterApiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(masterApiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
