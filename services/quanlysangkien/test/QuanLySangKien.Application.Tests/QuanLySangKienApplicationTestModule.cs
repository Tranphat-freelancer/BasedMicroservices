using Volo.Abp.Modularity;

namespace QuanLySangKien;

[DependsOn(
    typeof(QuanLySangKienApplicationModule),
    typeof(QuanLySangKienDomainTestModule)
    )]
public class QuanLySangKienApplicationTestModule : AbpModule
{

}
