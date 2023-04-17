using Volo.Abp.Settings;

namespace AuthAssignment.Settings;

public class AuthAssignmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AuthAssignmentSettings.MySetting1));
    }
}
