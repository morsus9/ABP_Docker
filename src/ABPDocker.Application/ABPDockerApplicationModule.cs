using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPDocker.Authorization;

namespace ABPDocker
{
    [DependsOn(
        typeof(ABPDockerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPDockerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPDockerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPDockerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
