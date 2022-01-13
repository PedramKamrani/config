using config.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace config;

[DependsOn(
    typeof(configEntityFrameworkCoreTestModule)
    )]
public class configDomainTestModule : AbpModule
{

}
