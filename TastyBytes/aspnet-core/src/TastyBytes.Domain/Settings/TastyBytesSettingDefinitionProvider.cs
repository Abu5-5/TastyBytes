using Volo.Abp.Settings;

namespace TastyBytes.Settings;

public class TastyBytesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TastyBytesSettings.MySetting1));
    }
}
