using Based.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Based;

[DependsOn(
    typeof(BasedEntityFrameworkCoreTestModule)
    )]
public class BasedDomainTestModule : AbpModule
{

}
