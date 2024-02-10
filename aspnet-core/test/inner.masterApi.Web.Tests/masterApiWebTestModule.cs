using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using inner.masterApi.EntityFrameworkCore;
using inner.masterApi.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace inner.masterApi.Web.Tests
{
    [DependsOn(
        typeof(masterApiWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class masterApiWebTestModule : AbpModule
    {
        public masterApiWebTestModule(masterApiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(masterApiWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(masterApiWebMvcModule).Assembly);
        }
    }
}