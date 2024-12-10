using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("RtplanSer", "RefPointSer")]
[Index("RefPointSer", Name = "XIF2DoseContribution")]
public partial class DoseContribution
{
    [Key]
    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Key]
    public long RefPointSer { get; set; }

    public long? CacheKeySer { get; set; }

    public double? DosePerFraction { get; set; }

    public int PrimaryFlag { get; set; }

    public int DicomSeqNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("RefPointSer")]
    [InverseProperty("DoseContribution")]
    public virtual RefPoint RefPointSerNavigation { get; set; } = null!;

    [ForeignKey("RtplanSer")]
    [InverseProperty("DoseContribution")]
    public virtual Rtplan RtplanSerNavigation { get; set; } = null!;
}
