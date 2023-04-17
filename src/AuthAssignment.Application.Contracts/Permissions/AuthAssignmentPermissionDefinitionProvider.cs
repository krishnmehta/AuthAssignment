using AuthAssignment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AuthAssignment.Permissions;

public class AuthAssignmentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AuthAssignmentPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AuthAssignmentPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AuthAssignmentResource>(name);
    }
}
