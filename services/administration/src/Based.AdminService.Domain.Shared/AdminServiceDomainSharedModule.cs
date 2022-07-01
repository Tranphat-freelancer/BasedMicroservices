using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Based.AdminService.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.SettingManagement;
using Volo.Abp.AuditLogging;
using Volo.Abp.PermissionManagement;
using Volo.Abp.FeatureManagement;

namespace Based.AdminService;

[DependsOn(
    typeof(AbpValidationModule)
)]
[DependsOn(typeof(AbpSettingManagementDomainSharedModule))]
    [DependsOn(typeof(AbpAuditLoggingDomainSharedModule))]
    [DependsOn(typeof(AbpPermissionManagementDomainSharedModule))]
    [DependsOn(typeof(AbpFeatureManagementDomainSharedModule))]
    public class AdminServiceDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AdminServiceDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AdminServiceResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/AdminService");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("AdminService", typeof(AdminServiceResource));
        });
    }
}
