using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TastyBytes.Data;
using Volo.Abp.DependencyInjection;

namespace TastyBytes.EntityFrameworkCore;

public class EntityFrameworkCoreTastyBytesDbSchemaMigrator
    : ITastyBytesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTastyBytesDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TastyBytesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TastyBytesDbContext>()
            .Database
            .MigrateAsync();
    }
}
