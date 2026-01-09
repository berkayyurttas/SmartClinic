using SmartClinic.Localization;
using Volo.Abp.Application.Services;

namespace SmartClinic;

/* Inherit your application services from this class.
 */
public abstract class SmartClinicAppService : ApplicationService
{
    protected SmartClinicAppService()
    {
        LocalizationResource = typeof(SmartClinicResource);
    }
}
