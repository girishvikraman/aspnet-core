using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EYVAPP.Data;
using Volo.Abp.DependencyInjection;

namespace EYVAPP.EntityFrameworkCore
{
    public class EntityFrameworkCoreEYVAPPDbSchemaMigrator
        : IEYVAPPDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreEYVAPPDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the EYVAPPMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<EYVAPPMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}