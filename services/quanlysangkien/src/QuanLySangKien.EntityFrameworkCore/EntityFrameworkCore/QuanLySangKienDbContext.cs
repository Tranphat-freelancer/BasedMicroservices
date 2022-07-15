using Microsoft.EntityFrameworkCore;
using QuanLySangKien.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.EntityFrameworkCore;

[ConnectionStringName(IdeaManagementDbProperties.ConnectionStringName)]
public class QuanLySangKienDbContext : AbpDbContext<QuanLySangKienDbContext>, IIdeaManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Field> Fields { get; set; }
    public DbSet<Unit> Units { get; set; }
    public QuanLySangKienDbContext(DbContextOptions<QuanLySangKienDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureQuanLySangKien();
    }
}
