using Based.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Based.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BasedController : AbpControllerBase
{
    protected BasedController()
    {
        LocalizationResource = typeof(BasedResource);
    }
}
