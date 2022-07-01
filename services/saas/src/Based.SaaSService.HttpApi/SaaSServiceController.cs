using Based.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Based.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
