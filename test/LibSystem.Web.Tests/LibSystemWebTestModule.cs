using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibSystem.EntityFrameworkCore;
using LibSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LibSystem.Web.Tests
{
    [DependsOn(
        typeof(LibSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LibSystemWebTestModule : AbpModule
    {
        public LibSystemWebTestModule(LibSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LibSystemWebMvcModule).Assembly);
        }
    }
}