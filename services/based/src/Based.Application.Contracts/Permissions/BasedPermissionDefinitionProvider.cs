using Based.Localization;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Based.Permissions;

public class BasedPermissionDefinitionProvider : PermissionDefinitionProvider
{
    protected IConfiguration _configuration { get; }
    public BasedPermissionDefinitionProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public override void Define(IPermissionDefinitionContext context)
    {

        var groups = _configuration.GetSection("GroupPermission").Get<List<GroupPermission>>();

        foreach (var item in groups)
        {
            var iGroup = context.AddGroup(item.GroupName, L(item.GroupName));
            //Define your own permissions here. Example:
            var parent = iGroup.AddPermission(item.GroupName + "." + item.Management, L(item.GroupName + "." + item.Management));
            parent.AddChild(item.GroupName + "." + item.Create, L(item.GroupName + "." + item.Create));
            parent.AddChild(item.GroupName + "." + item.Update, L(item.GroupName + "." + item.Update));
            parent.AddChild(item.GroupName + "." + item.Delete, L(item.GroupName + "." + item.Delete));
            foreach (var moreItem in item.More)
            {
                parent.AddChild(item.GroupName + "." + moreItem, L(item.GroupName + "." + moreItem));
            }
        }
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BasedResource>(name);
    }
}
