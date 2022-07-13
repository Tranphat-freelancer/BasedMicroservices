﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using EasyAbp.Abp.DynamicMenu;
using EasyAbp.Abp.DynamicEntity;
using EasyAbp.Abp.DynamicPermission;
using EasyAbp.Abp.EntityUi;

namespace Based;

[DependsOn(
    typeof(AbpEntityUiHttpApiClientModule),
    typeof(AbpDynamicMenuHttpApiClientModule),
    typeof(AbpDynamicEntityHttpApiClientModule),
    typeof(AbpDynamicPermissionHttpApiClientModule),
    typeof(BasedApplicationContractsModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class BasedHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(BasedApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BasedHttpApiClientModule>();
        });
    }
}
