using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.EntityFrameworkCore;

[ConnectionStringName(QuanLySangKienDbProperties.ConnectionStringName)]
public interface IQuanLySangKienDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
