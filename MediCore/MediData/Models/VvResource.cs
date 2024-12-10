using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvResource
{
    public long ResourceSer { get; set; }

    [StringLength(30)]
    public string ResourceType { get; set; } = null!;

    public int ResourceTypeNum { get; set; }

    [StringLength(64)]
    public string Value { get; set; } = null!;

    [StringLength(64)]
    public string ResourceTypeCode { get; set; } = null!;
}
