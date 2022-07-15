namespace Based;

public static class BasedDbProperties
{
    public static string DbTablePrefix { get; set; } = "Service_";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Based";
}
