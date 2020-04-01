using EYVAPP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EYVAPP
{
    [DependsOn(
        typeof(EYVAPPEntityFrameworkCoreTestModule)
        )]
    public class EYVAPPDomainTestModule : AbpModule
    {

    }
}