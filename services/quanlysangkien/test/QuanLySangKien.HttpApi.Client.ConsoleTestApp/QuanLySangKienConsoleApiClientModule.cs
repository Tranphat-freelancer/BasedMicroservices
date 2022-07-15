using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace QuanLySangKien;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QuanLySangKienHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class QuanLySangKienConsoleApiClientModule : AbpModule
{

}
