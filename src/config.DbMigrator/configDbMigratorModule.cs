using config.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace config.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(configEntityFrameworkCoreModule),
    typeof(configApplicationContractsModule)
    )]
public class configDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
