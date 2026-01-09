using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartClinic.Data;
using Volo.Abp.DependencyInjection;

namespace SmartClinic.EntityFrameworkCore;

public class EntityFrameworkCoreSmartClinicDbSchemaMigrator
    : ISmartClinicDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSmartClinicDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SmartClinicDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SmartClinicDbContext>()
            .Database
            .MigrateAsync();
    }
}
