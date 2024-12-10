using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGblUnitDoseConfig
{
    [StringLength(64)]
    public string ConfigurationItemId { get; set; } = null!;

    [StringLength(254)]
    public string? ConfigValue { get; set; }
}
