using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AuthAssignment.Data;
using Volo.Abp.DependencyInjection;

namespace AuthAssignment.EntityFrameworkCore;

public class EntityFrameworkCoreAuthAssignmentDbSchemaMigrator
    : IAuthAssignmentDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAuthAssignmentDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AuthAssignmentDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AuthAssignmentDbContext>()
            .Database
            .MigrateAsync();
    }
}
