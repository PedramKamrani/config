using System;
using Volo.Abp.Application.Dtos;

namespace config.Configs;

public class ConfigDto : AuditedEntityDto<Guid>
{
    public string Key { get; set; }
    public string Value { get; set; }
    public Guid Moduleid { get; set; }
}

