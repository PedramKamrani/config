using config.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace config.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class configPageModel : AbpPageModel
{
    protected configPageModel()
    {
        LocalizationResourceType = typeof(configResource);
    }
}
