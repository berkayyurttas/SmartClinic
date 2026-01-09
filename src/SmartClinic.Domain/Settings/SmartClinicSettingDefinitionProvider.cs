using Volo.Abp.Settings;

namespace SmartClinic.Settings;

public class SmartClinicSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SmartClinicSettings.MySetting1));
    }
}
