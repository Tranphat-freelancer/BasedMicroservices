using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.SettingManagement;
using Volo.Abp.PermissionManagement;
using Volo.Abp.FeatureManagement;

namespace Based.AdminService;

[DependsOn(
    typeof(AdminServiceDomainModule),
    typeof(AdminServiceApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpSettingManagementApplicationModule))]
    [DependsOn(typeof(AbpPermissionManagementApplicationModule))]
    [DependsOn(typeof(AbpFeatureManagementApplicationModule))]
    public class AdminServiceApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AdminServiceApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AdminServiceApplicationModule>(validate: true);
        });
    }
}
