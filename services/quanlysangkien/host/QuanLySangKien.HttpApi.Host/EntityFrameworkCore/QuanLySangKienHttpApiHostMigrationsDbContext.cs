using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.EntityFrameworkCore;

public class QuanLySangKienHttpApiHostMigrationsDbContext : AbpDbContext<QuanLySangKienHttpApiHostMigrationsDbContext>
{
    public QuanLySangKienHttpApiHostMigrationsDbContext(DbContextOptions<QuanLySangKienHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureQuanLySangKien();
    }
}
