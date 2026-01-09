using Volo.Abp.Modularity;

namespace SmartClinic;

public abstract class SmartClinicApplicationTestBase<TStartupModule> : SmartClinicTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
