using Based.AdminService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Based.AdminService;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AdminServiceEntityFrameworkCoreTestModule)
    )]
public class AdminServiceDomainTestModule : AbpModule
{

}
