using Volo.Abp.Reflection;

namespace QuanLySangKien.Permissions;

public class QuanLySangKienPermissions
{
    public const string GroupName = "QuanLySangKien";
    public class QuanLySangKien
    {
        public const string Default = GroupName + ".Management";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
    public class FieldManagement
    {
        public const string Module = GroupName + ".Field";
        public const string Default = Module + ".Management";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
    public class UnitManagement
    {
        public const string Module = GroupName + ".Unit";
        public const string Default = Module + ".Management";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(QuanLySangKienPermissions));
    }
}
