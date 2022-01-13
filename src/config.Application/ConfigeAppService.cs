using Abp.Application.Services.Dto;
using config.Configs;
using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace config;

public class ConfigeAppService :
    CrudAppService<Config, ConfigDto, Guid, PagedAndSortedResultRequestDto>, ICongigAppService
{
    public ConfigeAppService(IRepository<Config, Guid> repository) : base(repository)
    {

    }
}

