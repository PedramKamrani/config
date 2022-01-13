using System;
using System.Collections.Generic;
using System.Text;
using config.Localization;
using Volo.Abp.Application.Services;

namespace config;

/* Inherit your application services from this class.
 */
public abstract class configAppService : ApplicationService
{
    protected configAppService()
    {
        LocalizationResource = typeof(configResource);
    }
}
