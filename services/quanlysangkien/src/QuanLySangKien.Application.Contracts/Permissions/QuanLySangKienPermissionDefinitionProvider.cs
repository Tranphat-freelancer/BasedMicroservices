using QuanLySangKien.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QuanLySangKien.Permissions;

public class QuanLySangKienPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QuanLySangKienPermissions.GroupName, L("Permission:QuanLySangKien"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QuanLySangKienResource>(name);
    }
}
