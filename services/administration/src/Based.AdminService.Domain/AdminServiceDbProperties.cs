namespace Based.AdminService;

public static class AdminServiceDbProperties
{
    public static string DbTablePrefix { get; set; } = "AdminService";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AdminService";
}
