using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Emailing;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace Based;

[DependsOn(
    typeof(BasedDomainSharedModule),
    typeof(AbpAuditLoggingDomainModule),
    typeof(AbpBackgroundJobsDomainModule),
    typeof(AbpFeatureManagementDomainModule),
    typeof(AbpIdentityDomainModule),
    typeof(AbpPermissionManagementDomainIdentityModule),
    typeof(AbpIdentityServerDomainModule),
    typeof(AbpPermissionManagementDomainIdentityServerModule),
    typeof(AbpSettingManagementDomainModule),
    typeof(AbpTenantManagementDomainModule),
    typeof(AbpEmailingModule)
)]
//[DependsOn(typeof(AbpEntityUiDomainModule))]
//[DependsOn(typeof(AbpEntityUiDynamicEntityDomainModule))]
//[DependsOn(typeof(AbpDynamicMenuDomainModule))]
//[DependsOn(typeof(AbpDynamicEntityDomainModule))]
//[DependsOn(typeof(AbpDynamicPermissionDomainModule))]
public class BasedDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //handler add Module to Entity UI
        //Configure<AbpEntityUiOptions>(options =>
        //{
        //    options.Modules.Add("BasedEntityUi", new AbpEntityUiModuleOptions(typeof(BasedDomainModule)));
        //});


#if DEBUG
        context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
    }
}
