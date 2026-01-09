using SmartClinic.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SmartClinic.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SmartClinicController : AbpControllerBase
{
    protected SmartClinicController()
    {
        LocalizationResource = typeof(SmartClinicResource);
    }
}
