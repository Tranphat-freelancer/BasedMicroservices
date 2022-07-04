using Based.Shared.Hosting;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;

namespace Based.Microservice.Shared;

[DependsOn(
    typeof(AbpEventBusRabbitMqModule),
    typeof(SharedHostingModule)
)]
public class SharedMicroserviceModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}