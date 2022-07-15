using QuanLySangKien.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuanLySangKien;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(QuanLySangKienEntityFrameworkCoreTestModule)
    )]
public class QuanLySangKienDomainTestModule : AbpModule
{

}
