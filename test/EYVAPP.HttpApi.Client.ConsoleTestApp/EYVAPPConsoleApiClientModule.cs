using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EYVAPP.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(EYVAPPHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class EYVAPPConsoleApiClientModule : AbpModule
    {
        
    }
}
