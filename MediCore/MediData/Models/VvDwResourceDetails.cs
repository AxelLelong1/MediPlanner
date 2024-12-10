using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwResourceDetails
{
    public long ResourceSer { get; set; }

    [StringLength(208)]
    public string ResourceName { get; set; } = null!;

    [StringLength(30)]
    public string ResourceType { get; set; } = null!;

    [StringLength(64)]
    public string? ResourceTypeCode { get; set; }

    public int ResourceTypeNum { get; set; }
}
