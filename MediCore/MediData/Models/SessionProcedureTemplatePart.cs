using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SessionProcedureTemplateSer", "SequenceNumber", Name = "XAKSessionProcedureTemplatePart", IsUnique = true)]
public partial class SessionProcedureTemplatePart
{
    [Key]
    public long SessionProcedureTemplatePartSer { get; set; }

    public long SessionProcedureTemplateSer { get; set; }

    public int SequenceNumber { get; set; }

    public double? AcqAdjustment { get; set; }

    [StringLength(32)]
    public string? ImageType { get; set; }

    public int AutoSave { get; set; }

    public int DoseAccumulation { get; set; }

    public int Continuous { get; set; }

    public int BeamOff { get; set; }

    public int DeviationImage { get; set; }

    public int? DevEnergy { get; set; }

    public int? DevDoseRate { get; set; }

    public int? DevGeometry { get; set; }

    public double? JawState { get; set; }

    [Column("MUSubtraction")]
    public int? Musubtraction { get; set; }

    [StringLength(64)]
    public string? AcquisitionMode { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(16)]
    public string ImageModality { get; set; } = null!;

    [ForeignKey("SessionProcedureTemplateSer")]
    [InverseProperty("SessionProcedureTemplatePart")]
    public virtual SessionProcedureTemplate SessionProcedureTemplateSerNavigation { get; set; } = null!;
}
