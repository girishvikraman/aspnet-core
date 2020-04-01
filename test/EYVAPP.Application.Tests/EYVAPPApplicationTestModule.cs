using Volo.Abp.Modularity;

namespace EYVAPP
{
    [DependsOn(
        typeof(EYVAPPApplicationModule),
        typeof(EYVAPPDomainTestModule)
        )]
    public class EYVAPPApplicationTestModule : AbpModule
    {

    }
}