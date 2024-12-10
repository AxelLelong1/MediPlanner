using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SessionProcedureSer", "SequenceNumber", Name = "XAK1SessionProcedurePart", IsUnique = true)]
[Index("RadiationSer", Name = "XIF2SessionProcedurePart")]
[Index("RtplanSer", Name = "XIF3SessionProcedurePart")]
public partial class SessionProcedurePart
{
    [Key]
    public long SessionProcedurePartSer { get; set; }

    public long? RadiationSer { get; set; }

    [StringLength(32)]
    public string? ImageType { get; set; }

    public int SequenceNumber { get; set; }

    public double? AcqAdjustment { get; set; }

    public int AutoSave { get; set; }

    public int DoseAccumulation { get; set; }

    public int Continuous { get; set; }

    public int BeamOff { get; set; }

    public int DeviationImage { get; set; }

    public int? DevEnergy { get; set; }

    public int? DevDoseRate { get; set; }

    public int? DevGeometry { get; set; }

    public double? JawState { get; set; }

    public double? DevCollX1 { get; set; }

    public double? DevCollX2 { get; set; }

    public double? DevCollY1 { get; set; }

    public double? DevCollY2 { get; set; }

    [Column("MUSubtraction")]
    public int? Musubtraction { get; set; }

    [StringLength(64)]
    public string? AcquisitionMode { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long SessionProcedureSer { get; set; }

    [StringLength(16)]
    public string ImageModality { get; set; } = null!;

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("SessionProcedurePart")]
    public virtual Radiation? RadiationSerNavigation { get; set; }

    [ForeignKey("RtplanSer")]
    [InverseProperty("SessionProcedurePart")]
    public virtual Rtplan? RtplanSerNavigation { get; set; }

    [ForeignKey("SessionProcedureSer")]
    [InverseProperty("SessionProcedurePart")]
    public virtual SessionProcedure SessionProcedureSerNavigation { get; set; } = null!;
}
