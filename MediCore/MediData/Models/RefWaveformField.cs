using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("RefWaveformRelationSer", "RadiationSer")]
[Index("RadiationSer", Name = "XIF955RefWaveformField")]
public partial class RefWaveformField
{
    [Key]
    public long RefWaveformRelationSer { get; set; }

    [Key]
    public long RadiationSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("RefWaveformField")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("RefWaveformRelationSer")]
    [InverseProperty("RefWaveformField")]
    public virtual RefWaveformRelation RefWaveformRelationSerNavigation { get; set; } = null!;
}
