using System.Threading.Tasks;

namespace EYVAPP.Data
{
    public interface IEYVAPPDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
