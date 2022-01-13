using Volo.Abp.Modularity;

namespace config;

[DependsOn(
    typeof(configApplicationModule),
    typeof(configDomainTestModule)
    )]
public class configApplicationTestModule : AbpModule
{

}
