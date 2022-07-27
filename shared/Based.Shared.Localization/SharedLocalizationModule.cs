using QuanLySangKien;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;

namespace Based.Shared.Localization;

[DependsOn(
    typeof(AbpValidationModule),
    typeof(BasedDomainSharedModule),
    typeof(QuanLySangKienDomainSharedModule)

)]
public class SharedLocalizationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigurLocalizationLanguages();
    }
    private void ConfigurLocalizationLanguages()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Languages.Add(new LanguageInfo("en", "en", "English"));
            options.Languages.Add(new LanguageInfo("vi", "vi", "Tiếng Việt"));
        });
    }
}