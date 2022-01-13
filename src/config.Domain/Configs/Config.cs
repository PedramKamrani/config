using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace config.Configs;

public class Config:FullAuditedAggregateRoot<Guid>
{
    public string Key { get; set; }
    public string Value { get; set; }
    public Guid Moduleid { get; set; }
}

