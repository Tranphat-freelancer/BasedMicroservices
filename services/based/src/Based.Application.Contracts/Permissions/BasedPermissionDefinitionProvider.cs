using Based.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Based.Permissions;

public class BasedPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BasedPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BasedPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BasedResource>(name);
    }
}
