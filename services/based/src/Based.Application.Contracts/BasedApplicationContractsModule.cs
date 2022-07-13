using EasyAbp.Abp.DynamicEntity;
using EasyAbp.Abp.DynamicMenu;
using EasyAbp.Abp.DynamicPermission;
using EasyAbp.Abp.EntityUi;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace Based;

[DependsOn(
    typeof(AbpEntityUiApplicationContractsModule),
    typeof(AbpDynamicMenuApplicationContractsModule),
    typeof(AbpDynamicEntityApplicationContractsModule),
    typeof(AbpDynamicPermissionApplicationContractsModule),
    typeof(BasedDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class BasedApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        BasedDtoExtensions.Configure();
    }
}
