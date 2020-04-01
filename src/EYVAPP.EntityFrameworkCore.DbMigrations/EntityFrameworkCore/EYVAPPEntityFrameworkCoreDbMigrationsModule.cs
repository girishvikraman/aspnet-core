using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EYVAPP.EntityFrameworkCore
{
    [DependsOn(
        typeof(EYVAPPEntityFrameworkCoreModule)
        )]
    public class EYVAPPEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<EYVAPPMigrationsDbContext>();
        }
    }
}
