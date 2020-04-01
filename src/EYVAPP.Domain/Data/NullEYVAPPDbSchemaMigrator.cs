using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EYVAPP.Data
{
    /* This is used if database provider does't define
     * IEYVAPPDbSchemaMigrator implementation.
     */
    public class NullEYVAPPDbSchemaMigrator : IEYVAPPDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}