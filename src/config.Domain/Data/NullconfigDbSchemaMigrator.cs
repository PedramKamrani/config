using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace config.Data;

/* This is used if database provider does't define
 * IconfigDbSchemaMigrator implementation.
 */
public class NullconfigDbSchemaMigrator : IconfigDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
