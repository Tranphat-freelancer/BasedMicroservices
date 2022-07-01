using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Based.IdentityService.EntityFrameworkCore;

public class IdentityServiceDbContextFactory : IDesignTimeDbContextFactory<IdentityServiceDbContext>
{
    public IdentityServiceDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<IdentityServiceDbContext>()
            .UseSqlServer(GetConnectionStringFromConfiguration());

        return new IdentityServiceDbContext(builder.Options);
    }

    private static string GetConnectionStringFromConfiguration()
    {
        return BuildConfiguration()
            .GetConnectionString(IdentityServiceDbProperties.ConnectionStringName);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(
                Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())?.Parent!.FullName!,
                    $"host{Path.DirectorySeparatorChar}Based.IdentityService.HttpApi.Host"
                )
            )
            .AddJsonFile("appsettings.json", false);

        return builder.Build();
    }
}