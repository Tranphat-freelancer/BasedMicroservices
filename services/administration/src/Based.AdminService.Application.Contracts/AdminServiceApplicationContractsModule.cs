using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.SettingManagement;
using Volo.Abp.PermissionManagement;
using Volo.Abp.FeatureManagement;

namespace Based.AdminService;

[DependsOn(
    typeof(AdminServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
[DependsOn(typeof(AbpSettingManagementApplicationContractsModule))]
    [DependsOn(typeof(AbpPermissionManagementApplicationContractsModule))]
    [DependsOn(typeof(AbpFeatureManagementApplicationContractsModule))]
    public class AdminServiceApplicationContractsModule : AbpModule
{

}
