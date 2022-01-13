using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace config.Web;

[Dependency(ReplaceServices = true)]
public class configBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "config";
}
