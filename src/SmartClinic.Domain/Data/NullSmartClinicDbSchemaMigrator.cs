using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SmartClinic.Data;

/* This is used if database provider does't define
 * ISmartClinicDbSchemaMigrator implementation.
 */
public class NullSmartClinicDbSchemaMigrator : ISmartClinicDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
