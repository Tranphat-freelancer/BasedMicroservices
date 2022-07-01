using Volo.Abp.Modularity;

namespace Based.AdminService;

[DependsOn(
    typeof(AdminServiceApplicationModule),
    typeof(AdminServiceDomainTestModule)
    )]
public class AdminServiceApplicationTestModule : AbpModule
{

}
