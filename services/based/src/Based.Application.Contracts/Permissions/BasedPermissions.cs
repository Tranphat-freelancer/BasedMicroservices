namespace Based.Permissions;

public static class BasedPermissions
{
    public const string GroupName = "Based";


    //Add your own permission names. Example:
    public const string Permission = GroupName + ".Management";
    public const string PermissionCreate = GroupName + ".Create";
    public const string PermissionUpdate = GroupName + ".Update";
    public const string PermissionDelete = GroupName + ".Delete";
}
public class GroupPermission
{
    public string GroupName { get; set; }
    public string Management { get; set; }
    public string Create { get; set; }
    public string Update { get; set; }
    public string Delete { get; set; }
    public string[] More { get; set; }
}