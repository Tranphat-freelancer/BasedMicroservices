using QuanLySangKien.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QuanLySangKien.Permissions;

public class QuanLySangKienPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QuanLySangKienPermissions.GroupName, L("QuanLySangKien:GroupName"));
        var quanlysangkienPermission = myGroup.AddPermission(QuanLySangKienPermissions.QuanLySangKien.Default, L("QuanLySangKien:Default"));
        quanlysangkienPermission.AddChild(QuanLySangKienPermissions.QuanLySangKien.Create);
        quanlysangkienPermission.AddChild(QuanLySangKienPermissions.QuanLySangKien.Update);
        quanlysangkienPermission.AddChild(QuanLySangKienPermissions.QuanLySangKien.Delete);
        var fieldPermission = quanlysangkienPermission.AddChild(QuanLySangKienPermissions.FieldManagement.Default, L("FieldManagement:Default"));
        fieldPermission.AddChild(QuanLySangKienPermissions.FieldManagement.Create);
        fieldPermission.AddChild(QuanLySangKienPermissions.FieldManagement.Update);
        fieldPermission.AddChild(QuanLySangKienPermissions.FieldManagement.Delete); 
        var unitPermission = quanlysangkienPermission.AddChild(QuanLySangKienPermissions.UnitManagement.Default, L("UnitManagement:Default"));
        unitPermission.AddChild(QuanLySangKienPermissions.UnitManagement.Create);
        unitPermission.AddChild(QuanLySangKienPermissions.UnitManagement.Update);
        unitPermission.AddChild(QuanLySangKienPermissions.UnitManagement.Delete);

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QuanLySangKienResource>(name);
    }
}
