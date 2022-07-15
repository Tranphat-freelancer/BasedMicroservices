using IdeaManagement;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.EntityFrameworkCore;

[ConnectionStringName(IdeaManagementDbProperties.ConnectionStringName)]
public interface IIdeaManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
