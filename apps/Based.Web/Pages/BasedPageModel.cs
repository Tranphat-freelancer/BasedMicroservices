using Based.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Based.Web.Pages;

public abstract class BasedPageModel : AbpPageModel
{
    protected BasedPageModel()
    {
        LocalizationResourceType = typeof(BasedResource);
    }
}
