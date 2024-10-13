using TastyBytes.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TastyBytes;

[DependsOn(
    typeof(TastyBytesEntityFrameworkCoreTestModule)
    )]
public class TastyBytesDomainTestModule : AbpModule
{

}
