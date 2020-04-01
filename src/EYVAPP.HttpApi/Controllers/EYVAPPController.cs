using EYVAPP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EYVAPP.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class EYVAPPController : AbpController
    {
        protected EYVAPPController()
        {
            LocalizationResource = typeof(EYVAPPResource);
        }
    }
}