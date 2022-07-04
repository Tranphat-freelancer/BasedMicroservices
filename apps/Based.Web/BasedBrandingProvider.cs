using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Based.Web;

[Dependency(ReplaceServices = true)]
public class BasedBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Based";
}
