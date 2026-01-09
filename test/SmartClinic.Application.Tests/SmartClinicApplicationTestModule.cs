using Volo.Abp.Modularity;

namespace SmartClinic;

[DependsOn(
    typeof(SmartClinicApplicationModule),
    typeof(SmartClinicDomainTestModule)
)]
public class SmartClinicApplicationTestModule : AbpModule
{

}
