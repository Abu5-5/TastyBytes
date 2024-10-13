using Volo.Abp.Modularity;

namespace TastyBytes;

[DependsOn(
    typeof(TastyBytesApplicationModule),
    typeof(TastyBytesDomainTestModule)
    )]
public class TastyBytesApplicationTestModule : AbpModule
{

}
