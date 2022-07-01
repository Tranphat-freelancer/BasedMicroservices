using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Based.AdminService.EntityFrameworkCore;

public class AdminServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AdminServiceHttpApiHostMigrationsDbContext>
{
    public AdminServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AdminServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AdminService"));

        return new AdminServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
