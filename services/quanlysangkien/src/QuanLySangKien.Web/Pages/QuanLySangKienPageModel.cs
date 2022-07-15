using QuanLySangKien.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QuanLySangKien.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class QuanLySangKienPageModel : AbpPageModel
{
    protected QuanLySangKienPageModel()
    {
        LocalizationResourceType = typeof(QuanLySangKienResource);
        ObjectMapperContext = typeof(QuanLySangKienWebModule);
    }
}
