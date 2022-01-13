using System.Threading.Tasks;

namespace config.Data;

public interface IconfigDbSchemaMigrator
{
    Task MigrateAsync();
}
