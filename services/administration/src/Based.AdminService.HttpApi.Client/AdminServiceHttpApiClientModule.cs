using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.SettingManagement;
using Volo.Abp.PermissionManagement;
using Volo.Abp.FeatureManagement;

namespace Based.AdminService;

[DependsOn(
    typeof(AdminServiceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
[DependsOn(typeof(AbpSettingManagementHttpApiClientModule))]
    [DependsOn(typeof(AbpPermissionManagementHttpApiClientModule))]
    [DependsOn(typeof(AbpFeatureManagementHttpApiClientModule))]
    public class AdminServiceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AdminServiceApplicationContractsModule).Assembly,
            AdminServiceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AdminServiceHttpApiClientModule>();
        });

    }
}
