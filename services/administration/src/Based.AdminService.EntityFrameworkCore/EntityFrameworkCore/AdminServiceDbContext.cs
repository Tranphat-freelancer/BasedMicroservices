using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;

namespace Based.AdminService.EntityFrameworkCore;

[ConnectionStringName(AdminServiceDbProperties.ConnectionStringName)]
public class AdminServiceDbContext : AbpDbContext<AdminServiceDbContext>, IAdminServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AdminServiceDbContext(DbContextOptions<AdminServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAdminService();
        builder.ConfigureSettingManagement();
            builder.ConfigureAuditLogging();
            builder.ConfigurePermissionManagement();
            builder.ConfigureFeatureManagement();
        }
}
