using SmartClinic.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SmartClinic.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SmartClinicEntityFrameworkCoreModule),
    typeof(SmartClinicApplicationContractsModule)
)]
public class SmartClinicDbMigratorModule : AbpModule
{
}
