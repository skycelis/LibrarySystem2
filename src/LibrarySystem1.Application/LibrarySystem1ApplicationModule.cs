using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem1.Authorization;

namespace LibrarySystem1
{
    [DependsOn(
        typeof(LibrarySystem1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LibrarySystem1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LibrarySystem1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LibrarySystem1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
