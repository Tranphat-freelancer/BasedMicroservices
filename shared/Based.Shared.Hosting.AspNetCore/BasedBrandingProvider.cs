using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Based.Shared.Hosting.AspNetCore
{
    [Dependency(ReplaceServices = true)]
    public class BasedBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Based";
    }
}
