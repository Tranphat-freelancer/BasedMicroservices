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
        //var groups = _configuration.GetSection("GroupPermission").Get<List<GroupPermission>>();

        //foreach (var gItem in groups)
        //{
        //    var iGroup = context.AddGroup(gItem.GroupName, L(gItem.GroupName));
        //    //Define your own permissions here. Example:
        //    foreach(var pItem in gItem.Permissions)
        //    {
        //        var parent = iGroup.AddPermission(pItem, L(pItem));
        //        foreach (var moreItem in gItem.Elements)
        //        {
        //            parent.AddChild(pItem + "." + moreItem, L(pItem + "." + moreItem));
        //        }
        //    }
        //}
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BasedResource>(name);
    }
}
