using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibSystem.Authorization;

namespace LibSystem
{
    [DependsOn(
        typeof(LibSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LibSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LibSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LibSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
