using QuanLySangKien;
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
    typeof(BasedDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]

//[DependsOn(typeof(AbpEntityUiApplicationContractsModule))]
//[DependsOn(typeof(AbpDynamicMenuApplicationContractsModule))]
//[DependsOn(typeof(AbpDynamicEntityApplicationContractsModule))]
//[DependsOn(typeof(AbpDynamicPermissionApplicationContractsModule))]
[DependsOn(typeof(QuanLySangKienApplicationContractsModule))]

public class BasedApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        BasedDtoExtensions.Configure();
    }
}
