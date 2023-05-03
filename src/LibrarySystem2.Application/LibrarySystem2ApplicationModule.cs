using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem2.Authorization;

namespace LibrarySystem2
{
    [DependsOn(
        typeof(LibrarySystem2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LibrarySystem2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LibrarySystem2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LibrarySystem2ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
