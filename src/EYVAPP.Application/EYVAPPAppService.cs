using System;
using System.Collections.Generic;
using System.Text;
using EYVAPP.Localization;
using Volo.Abp.Application.Services;

namespace EYVAPP
{
    /* Inherit your application services from this class.
     */
    public abstract class EYVAPPAppService : ApplicationService
    {
        protected EYVAPPAppService()
        {
            LocalizationResource = typeof(EYVAPPResource);
        }
    }
}
