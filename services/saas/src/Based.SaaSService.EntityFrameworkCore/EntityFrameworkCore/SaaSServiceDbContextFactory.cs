using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Based.SaaSService.EntityFrameworkCore;

public class SaaSServiceDbContextFactory : IDesignTimeDbContextFactory<SaaSServiceDbContext>
{
    public SaaSServiceDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<SaaSServiceDbContext>()
            .UseSqlServer(GetConnectionStringFromConfiguration());

        return new SaaSServiceDbContext(builder.Options);
    }

    private static string GetConnectionStringFromConfiguration()
    {
        return BuildConfiguration()
            .GetConnectionString(SaaSServiceDbProperties.ConnectionStringName);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(
                Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())?.Parent!.FullName!,
                    $"host{Path.DirectorySeparatorChar}Based.SaaSService.HttpApi.Host"
                )
            )
            .AddJsonFile("appsettings.json", false);

        return builder.Build();
    }
}