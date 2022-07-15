using QuanLySangKien.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QuanLySangKien;

public abstract class QuanLySangKienController : AbpControllerBase
{
    protected QuanLySangKienController()
    {
        LocalizationResource = typeof(QuanLySangKienResource);
    }
}
