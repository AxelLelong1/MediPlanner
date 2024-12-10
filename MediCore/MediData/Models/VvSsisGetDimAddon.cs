using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSsisGetDimAddon
{
    [StringLength(16)]
    public string AddOnId { get; set; } = null!;

    [StringLength(64)]
    public string? AddOnName { get; set; }

    [StringLength(30)]
    public string? AddOnType { get; set; }

    [StringLength(64)]
    public string? AddOnSubType { get; set; }

    public long AddOnSer { get; set; }

    public long ResourceSer { get; set; }
}
