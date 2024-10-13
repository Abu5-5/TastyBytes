using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TastyBytes;

[Dependency(ReplaceServices = true)]
public class TastyBytesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TastyBytes";
}
