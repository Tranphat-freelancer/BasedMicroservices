using Volo.Abp.Reflection;

namespace Based.AdminService.Permissions;

public class AdminServicePermissions
{
    public const string GroupName = "AdminService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AdminServicePermissions));
    }
}
