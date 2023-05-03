using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem2.Configuration;

namespace LibrarySystem2.Web.Host.Startup
{
    [DependsOn(
       typeof(LibrarySystem2WebCoreModule))]
    public class LibrarySystem2WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibrarySystem2WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystem2WebHostModule).GetAssembly());
        }
    }
}
