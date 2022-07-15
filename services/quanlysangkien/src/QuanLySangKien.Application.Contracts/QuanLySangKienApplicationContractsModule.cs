using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace QuanLySangKien;

[DependsOn(
    typeof(QuanLySangKienDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class QuanLySangKienApplicationContractsModule : AbpModule
{

}
