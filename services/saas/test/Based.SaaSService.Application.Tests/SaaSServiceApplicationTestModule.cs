using Volo.Abp.Modularity;

namespace Based.SaaSService;

[DependsOn(
    typeof(SaaSServiceApplicationModule),
    typeof(SaaSServiceDomainTestModule)
    )]
public class SaaSServiceApplicationTestModule : AbpModule
{

}
