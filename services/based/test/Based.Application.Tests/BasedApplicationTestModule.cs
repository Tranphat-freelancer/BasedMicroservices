using Volo.Abp.Modularity;

namespace Based;

[DependsOn(
    typeof(BasedApplicationModule),
    typeof(BasedDomainTestModule)
    )]
public class BasedApplicationTestModule : AbpModule
{

}
