using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem1.Configuration;

namespace LibrarySystem1.Web.Startup
{
    [DependsOn(typeof(LibrarySystem1WebCoreModule))]
    public class LibrarySystem1WebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibrarySystem1WebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<LibrarySystem1NavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystem1WebMvcModule).GetAssembly());
        }
    }
}
