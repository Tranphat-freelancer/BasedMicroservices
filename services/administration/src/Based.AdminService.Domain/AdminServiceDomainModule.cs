using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;
using Volo.Abp.AuditLogging;
using Volo.Abp.PermissionManagement;
using Volo.Abp.FeatureManagement;

namespace Based.AdminService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AdminServiceDomainSharedModule)
)]
[DependsOn(typeof(AbpSettingManagementDomainModule))]
    [DependsOn(typeof(AbpAuditLoggingDomainModule))]
    [DependsOn(typeof(AbpPermissionManagementDomainModule))]
    [DependsOn(typeof(AbpFeatureManagementDomainModule))]
    public class AdminServiceDomainModule : AbpModule
{

}
