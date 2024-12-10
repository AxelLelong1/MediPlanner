using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("RadiationSer", "RefPointSer", "RtplanSer")]
[Index("RtplanSer", Name = "XIF1RadiationRefPoint")]
[Index("RefPointSer", Name = "XIF3RadiationRefPoint")]
public partial class RadiationRefPoint
{
    [Key]
    public long RadiationSer { get; set; }

    [Key]
    public long RefPointSer { get; set; }

    [Key]
    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long? CacheKeySer { get; set; }

    public double? FieldDose { get; set; }

    public int DoseSpecificationFlag { get; set; }

    public double? Depth { get; set; }

    [Column("PSSD")]
    public double? Pssd { get; set; }

    public int DominantFieldFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int NominalFlag { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("RadiationRefPoint")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("RefPointSer")]
    [InverseProperty("RadiationRefPoint")]
    public virtual RefPoint RefPointSerNavigation { get; set; } = null!;

    [ForeignKey("RtplanSer")]
    [InverseProperty("RadiationRefPoint")]
    public virtual Rtplan RtplanSerNavigation { get; set; } = null!;
}
