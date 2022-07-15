using QuanLySangKien.Localization;
using Volo.Abp.Application.Services;

namespace QuanLySangKien;

public abstract class QuanLySangKienAppService : ApplicationService
{
    protected QuanLySangKienAppService()
    {
        LocalizationResource = typeof(QuanLySangKienResource);
        ObjectMapperContext = typeof(QuanLySangKienApplicationModule);
    }
}
