using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QuanLySangKien.EntityFrameworkCore;

public class QuanLySangKienHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<QuanLySangKienHttpApiHostMigrationsDbContext>
{
    public QuanLySangKienHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<QuanLySangKienHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("QuanLySangKien"));

        return new QuanLySangKienHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
