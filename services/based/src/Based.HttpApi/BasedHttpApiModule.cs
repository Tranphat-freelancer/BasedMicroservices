using Based.Localization;
using Localization.Resources.AbpUi;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace Based;

[DependsOn(
    typeof(BasedApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
//[DependsOn(typeof(AbpEntityUiHttpApiModule))]
//[DependsOn(typeof(AbpDynamicMenuHttpApiModule))]
//[DependsOn(typeof(AbpDynamicEntityHttpApiModule))]
//[DependsOn(typeof(AbpDynamicPermissionHttpApiModule))]

public class BasedHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<BasedResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
