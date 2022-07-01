using Based.AdminService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Based.AdminService;

public abstract class AdminServiceController : AbpControllerBase
{
    protected AdminServiceController()
    {
        LocalizationResource = typeof(AdminServiceResource);
    }
}
