using config.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace config.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class configController : AbpControllerBase
{
    protected configController()
    {
        LocalizationResource = typeof(configResource);
    }
}
