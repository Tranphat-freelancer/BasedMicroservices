using Localization.Resources.AbpUi;
using QuanLySangKien.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace QuanLySangKien;

[DependsOn(
    typeof(QuanLySangKienApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class QuanLySangKienHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(QuanLySangKienHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<QuanLySangKienResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
