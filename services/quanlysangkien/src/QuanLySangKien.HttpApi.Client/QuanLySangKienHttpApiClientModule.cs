using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace QuanLySangKien;

[DependsOn(
    typeof(QuanLySangKienApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class QuanLySangKienHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(QuanLySangKienApplicationContractsModule).Assembly,
            QuanLySangKienRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<QuanLySangKienHttpApiClientModule>();
        });

    }
}
