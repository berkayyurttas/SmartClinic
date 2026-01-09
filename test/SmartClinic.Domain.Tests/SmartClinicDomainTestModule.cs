using Volo.Abp.Modularity;

namespace SmartClinic;

[DependsOn(
    typeof(SmartClinicDomainModule),
    typeof(SmartClinicTestBaseModule)
)]
public class SmartClinicDomainTestModule : AbpModule
{

}
