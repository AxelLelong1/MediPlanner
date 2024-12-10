using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvBrachyFieldHstry
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    public long RadiationHstrySer { get; set; }

    [StringLength(16)]
    public string BrachyTreatmentType { get; set; } = null!;

    public int ChannelNumber { get; set; }

    public double ChannelLength { get; set; }

    public double SpecifiedChannelTotalTime { get; set; }

    public double ChannelReferenceAirKerma { get; set; }

    public double DeliveredChannelTotalTime { get; set; }

    public int? SpecifiedNumberOfPulses { get; set; }

    public int? DeliveredNumberOfPulses { get; set; }

    public double? SpecifiedPulseRepetitionInterval { get; set; }

    public double? DeliveredPulseRepetitionInterval { get; set; }

    [StringLength(64)]
    public string? SourceSerialNumber { get; set; }

    [StringLength(64)]
    public string SourceIsotopeName { get; set; } = null!;

    public double ReferenceAirKermaRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SourceStrengthReferenceDateTime { get; set; }

    public int NumberOfSourcePositions { get; set; }
}
