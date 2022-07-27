using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Based.Shared.Hosting
{
    [DependsOn(
        typeof(AbpDataModule),
        typeof(AbpAutofacModule)
    )]
    public class SharedHostingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureDatabaseConnections();
        }
        private void ConfigureDatabaseConnections()
        {
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.Databases.Configure("Based", database =>
                {
                    //AdminService
                    database.MappedConnections.Add("AbpAuditLogging");
                    database.MappedConnections.Add("AbpPermissionManagement");
                    database.MappedConnections.Add("AbpSettingManagement");
                    database.MappedConnections.Add("AbpFeatureManagement");
                    //SaaSService
                    database.MappedConnections.Add("AbpTenantManagement");
                    database.IsUsedByTenants = false;
                    //IdentityService
                    database.MappedConnections.Add("AbpIdentity");
                    database.MappedConnections.Add("AbpIdentityServer");
                });

            });
        }
    }
}

