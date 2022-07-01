using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Based.AdminService.EntityFrameworkCore;

public class AdminServiceHttpApiHostMigrationsDbContext : AbpDbContext<AdminServiceHttpApiHostMigrationsDbContext>
{
    public AdminServiceHttpApiHostMigrationsDbContext(DbContextOptions<AdminServiceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAdminService();
    }
}
