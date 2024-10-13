using TastyBytes.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TastyBytes.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TastyBytesEntityFrameworkCoreModule),
    typeof(TastyBytesApplicationContractsModule)
    )]
public class TastyBytesDbMigratorModule : AbpModule
{
}
