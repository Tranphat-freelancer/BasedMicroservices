namespace Based.Permissions;

public static class BasedPermissions
{
    public const string GroupName = "Based";


    //Add your own permission names. Example:
    public const string Permission = GroupName + ".Management";
    public const string PermissionCreate = GroupName + ".Create";
    public const string PermissionUpdate = GroupName + ".Update";
    public const string PermissionDelete = GroupName + ".Delete";

    public class Field
    {
        public const string Default = GroupName + ".Field";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
public class GroupPermission
{
    public string GroupName { get; set; }
    public string[] Permissions { get; set; }
    public string[] Elements { get; set; }
}
