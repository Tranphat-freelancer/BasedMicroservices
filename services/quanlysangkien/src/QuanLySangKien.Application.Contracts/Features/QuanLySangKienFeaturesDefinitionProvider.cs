using QuanLySangKien.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace QuanLySangKien.Permissions;

public class QuanLySangKienFeaturesDefinitionProvider : FeatureDefinitionProvider
{
    public override void Define(IFeatureDefinitionContext context)
    {
        var myGroup = context.AddGroup(QuanLySangKienFeatures.GroupName);
        myGroup.AddFeature(
            QuanLySangKienFeatures.QuanLySangKien.Default,
            defaultValue: "false",
            displayName: L("QuanLySangKien"),
            valueType: new ToggleStringValueType());
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QuanLySangKienResource>(name);
    }
}
