using Volo.Abp.Modularity;

namespace SmartClinic;

/* Inherit from this class for your domain layer tests. */
public abstract class SmartClinicDomainTestBase<TStartupModule> : SmartClinicTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
