using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem1.EntityFrameworkCore;
using LibrarySystem1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LibrarySystem1.Web.Tests
{
    [DependsOn(
        typeof(LibrarySystem1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LibrarySystem1WebTestModule : AbpModule
    {
        public LibrarySystem1WebTestModule(LibrarySystem1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystem1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LibrarySystem1WebMvcModule).Assembly);
        }
    }
}