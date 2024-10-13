using System.Threading.Tasks;

namespace TastyBytes.Data;

public interface ITastyBytesDbSchemaMigrator
{
    Task MigrateAsync();
}
