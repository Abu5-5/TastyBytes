using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TastyBytes.Data;

/* This is used if database provider does't define
 * ITastyBytesDbSchemaMigrator implementation.
 */
public class NullTastyBytesDbSchemaMigrator : ITastyBytesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
