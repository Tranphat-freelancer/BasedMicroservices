using Based.EntityFrameworkCore;
using Based.Shared.Hosting;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

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
        Configure<AbpMultiTenancyOptions>(options =>
        {
            options.IsEnabled = MultiTenancyConsts.IsEnabled;
        });
    }
}