using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.EntityFrameworkCore;

[ConnectionStringName(QuanLySangKienDbProperties.ConnectionStringName)]
public class QuanLySangKienDbContext : AbpDbContext<QuanLySangKienDbContext>, IQuanLySangKienDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

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
