using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YJ.PF.Authorization;

namespace YJ.PF
{
    [DependsOn(
        typeof(PFCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PFApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PFAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PFApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
