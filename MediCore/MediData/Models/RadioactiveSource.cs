using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RadioactiveSourceModelSer", Name = "XIF413BrachySource")]
[Index("ResourceSer", Name = "XIF419BrachySource")]
public partial class RadioactiveSource
{
    [Key]
    public long RadioactiveSourceSer { get; set; }

    public long RadioactiveSourceModelSer { get; set; }

    public long? ResourceSer { get; set; }

    [StringLength(16)]
    public string RadioactiveSourceId { get; set; } = null!;

    [StringLength(64)]
    public string? RadioactiveSourceName { get; set; }

    public int? SourceNumber { get; set; }

    [StringLength(64)]
    public string? SourceSerialNo { get; set; }

    public double? SourceStrength { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CalibrationDate { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("RadioactiveSourceModelSer")]
    [InverseProperty("RadioactiveSource")]
    public virtual RadioactiveSourceModel RadioactiveSourceModelSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("RadioactiveSource")]
    public virtual RadiationDevice? ResourceSerNavigation { get; set; }

    [InverseProperty("RadioactiveSourceSerNavigation")]
    public virtual ICollection<SourcePosition> SourcePosition { get; set; } = new List<SourcePosition>();
}
