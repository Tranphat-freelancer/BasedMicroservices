using Based.AdminService;
using Based.AdminService.EntityFrameworkCore;
using Based.IdentityService;
using Based.IdentityService.EntityFrameworkCore;
using Based.SaaSService;
using Based.SaaSService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Based.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SaaSServiceEntityFrameworkCoreModule),
    typeof(AdminServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(SaaSServiceApplicationContractsModule),
    typeof(AdminServiceApplicationContractsModule),
    typeof(IdentityServiceApplicationContractsModule)
    //typeof(BasedHostingModule)
    )]
public class BasedDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
