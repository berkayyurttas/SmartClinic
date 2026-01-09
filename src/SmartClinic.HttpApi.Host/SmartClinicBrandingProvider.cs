using Microsoft.Extensions.Localization;
using SmartClinic.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SmartClinic;

[Dependency(ReplaceServices = true)]
public class SmartClinicBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SmartClinicResource> _localizer;

    public SmartClinicBrandingProvider(IStringLocalizer<SmartClinicResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
