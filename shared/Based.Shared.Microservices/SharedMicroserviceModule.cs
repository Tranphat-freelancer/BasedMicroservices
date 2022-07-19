using Based.EntityFrameworkCore;
using Based.Shared.Hosting;
using Volo.Abp.Modularity;

namespace Based.Shared.Microservices;

[DependsOn(
    //typeof(AbpEventBusRabbitMqModule),
    typeof(BasedEntityFrameworkCoreModule),
    typeof(SharedHostingModule)
)]
public class SharedMicroserviceModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}