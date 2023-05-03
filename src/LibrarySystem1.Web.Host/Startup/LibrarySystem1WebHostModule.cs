using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem1.Configuration;

namespace LibrarySystem1.Web.Host.Startup
{
    [DependsOn(
       typeof(LibrarySystem1WebCoreModule))]
    public class LibrarySystem1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibrarySystem1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystem1WebHostModule).GetAssembly());
        }
    }
}
