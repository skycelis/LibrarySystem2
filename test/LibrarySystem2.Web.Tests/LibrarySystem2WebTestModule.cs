using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem2.EntityFrameworkCore;
using LibrarySystem2.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LibrarySystem2.Web.Tests
{
    [DependsOn(
        typeof(LibrarySystem2WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LibrarySystem2WebTestModule : AbpModule
    {
        public LibrarySystem2WebTestModule(LibrarySystem2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystem2WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LibrarySystem2WebMvcModule).Assembly);
        }
    }
}