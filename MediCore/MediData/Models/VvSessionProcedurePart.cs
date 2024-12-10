using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSessionProcedurePart
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public int SessionNum { get; set; }

    [StringLength(16)]
    public string SessionProcedureTemplateId { get; set; } = null!;

    public long? PlanSetupSer { get; set; }

    [StringLength(16)]
    public string? PlanSetupId { get; set; }

    [StringLength(16)]
    public string? RadiationId { get; set; }

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
}
