using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvVaAddOnValidation
{
    [Column("ConfiguredEMTSer")]
    public long ConfiguredEmtser { get; set; }

    public long AddOnSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string TechniqueId { get; set; } = null!;

    public int Energy { get; set; }

    [StringLength(16)]
    public string RadiationType { get; set; } = null!;
}
