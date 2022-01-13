using System;
using System.ComponentModel.DataAnnotations;

namespace config.Configs;

public class CreateAndUpdate
{
    [Required(ErrorMessage =MessageAttribuites.IsRequired)]
    public string Key { get; set; }

    [Required(ErrorMessage = MessageAttribuites.IsRequired)]
    public string Value { get; set; }
    public Guid Moduleid { get; set; } = Guid.Empty;
}

