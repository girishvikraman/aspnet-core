using EYVAPP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EYVAPP.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EYVAPPEntityFrameworkCoreDbMigrationsModule),
        typeof(EYVAPPApplicationContractsModule)
        )]
    public class EYVAPPDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
