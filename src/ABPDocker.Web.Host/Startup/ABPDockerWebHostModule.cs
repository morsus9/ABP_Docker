using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPDocker.Configuration;

namespace ABPDocker.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPDockerWebCoreModule))]
    public class ABPDockerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPDockerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPDockerWebHostModule).GetAssembly());
        }
    }
}
