using System;
using System.Collections.Generic;
using System.Text;
using Based.Localization;
using Volo.Abp.Application.Services;

namespace Based;

/* Inherit your application services from this class.
 */
public abstract class BasedAppService : ApplicationService
{
    protected BasedAppService()
    {
        LocalizationResource = typeof(BasedResource);
    }
}
