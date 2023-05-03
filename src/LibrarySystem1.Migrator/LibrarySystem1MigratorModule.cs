using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem1.Configuration;
using LibrarySystem1.EntityFrameworkCore;
using LibrarySystem1.Migrator.DependencyInjection;

namespace LibrarySystem1.Migrator
{
    [DependsOn(typeof(LibrarySystem1EntityFrameworkModule))]
    public class LibrarySystem1MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public LibrarySystem1MigratorModule(LibrarySystem1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(LibrarySystem1MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                LibrarySystem1Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystem1MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
