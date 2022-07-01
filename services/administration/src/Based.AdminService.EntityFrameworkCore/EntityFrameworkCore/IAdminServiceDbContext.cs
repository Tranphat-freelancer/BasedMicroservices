using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Based.AdminService.EntityFrameworkCore;

[ConnectionStringName(AdminServiceDbProperties.ConnectionStringName)]
public interface IAdminServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
