using Volo.Abp.Settings;

namespace config.Settings;

public class configSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(configSettings.MySetting1));
    }
}
