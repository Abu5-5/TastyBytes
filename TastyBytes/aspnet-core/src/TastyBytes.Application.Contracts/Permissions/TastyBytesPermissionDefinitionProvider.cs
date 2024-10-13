using TastyBytes.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TastyBytes.Permissions;

public class TastyBytesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TastyBytesPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TastyBytesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TastyBytesResource>(name);
    }
}
