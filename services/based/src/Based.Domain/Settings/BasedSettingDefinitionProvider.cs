using Volo.Abp.Settings;

namespace Based.Settings;

public class BasedSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BasedSettings.MySetting1));
    }
}
