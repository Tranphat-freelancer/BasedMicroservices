using Volo.Abp.Reflection;

namespace QuanLySangKien.Permissions;

public class QuanLySangKienPermissions
{
    public const string GroupName = "QuanLySangKien";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(QuanLySangKienPermissions));
    }
}
