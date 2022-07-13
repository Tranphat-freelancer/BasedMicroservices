using EasyAbp.Abp.DynamicEntity.EntityFrameworkCore;
using EasyAbp.Abp.DynamicMenu.EntityFrameworkCore;
using EasyAbp.Abp.DynamicPermission.EntityFrameworkCore;
using EasyAbp.Abp.EntityUi.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Based.EntityFrameworkCore;

[DependsOn(
    typeof(BasedDomainModule),
    typeof(AbpEntityUiEntityFrameworkCoreModule),
    typeof(AbpDynamicMenuEntityFrameworkCoreModule),
    typeof(AbpDynamicEntityEntityFrameworkCoreModule),
    typeof(AbpDynamicPermissionEntityFrameworkCoreModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpIdentityServerEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule)
    )]
public class BasedEntityFrameworkCoreModule : AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<BasedDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also BasedMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });
        //disable datafilter
        //Configure<AbpDataFilterOptions>(options =>
        //{
        //    options.DefaultStates[typeof(ISoftDelete)] = new DataFilterState(isEnabled: false);
        //});
    }
}
