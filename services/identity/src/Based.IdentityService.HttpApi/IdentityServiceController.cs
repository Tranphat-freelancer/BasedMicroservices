using Based.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Based.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
