using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace QuanLySangKien;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(QuanLySangKienDomainSharedModule)
)]
public class QuanLySangKienDomainModule : AbpModule
{

}
