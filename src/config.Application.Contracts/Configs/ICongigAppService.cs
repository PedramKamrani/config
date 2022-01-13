using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace config.Configs;

public interface ICongigAppService:ICrudAppService
    <ConfigDto, Guid, PagedAndSortedResultRequestDto, CreateAndUpdate>
{
}

