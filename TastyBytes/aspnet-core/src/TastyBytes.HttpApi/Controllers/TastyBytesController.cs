using TastyBytes.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TastyBytes.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TastyBytesController : AbpControllerBase
{
    protected TastyBytesController()
    {
        LocalizationResource = typeof(TastyBytesResource);
    }
}
