using System;
using System.Collections.Generic;
using System.Text;
using TastyBytes.Localization;
using Volo.Abp.Application.Services;

namespace TastyBytes;

/* Inherit your application services from this class.
 */
public abstract class TastyBytesAppService : ApplicationService
{
    protected TastyBytesAppService()
    {
        LocalizationResource = typeof(TastyBytesResource);
    }
}
