using Based.AdminService.Localization;
using Volo.Abp.Application.Services;

namespace Based.AdminService;

public abstract class AdminServiceAppService : ApplicationService
{
    protected AdminServiceAppService()
    {
        LocalizationResource = typeof(AdminServiceResource);
        ObjectMapperContext = typeof(AdminServiceApplicationModule);
    }
}
