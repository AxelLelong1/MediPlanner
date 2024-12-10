using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class BrachyFieldHstry
{
    [Key]
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

    [ForeignKey("RadiationHstrySer")]
    [InverseProperty("BrachyFieldHstry")]
    public virtual RadiationHstry RadiationHstrySerNavigation { get; set; } = null!;
}
