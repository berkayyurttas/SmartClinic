using System.Threading.Tasks;

namespace SmartClinic.Data;

public interface ISmartClinicDbSchemaMigrator
{
    Task MigrateAsync();
}
