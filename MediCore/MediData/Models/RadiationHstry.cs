using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HstryDateTime", Name = "XIE1RadiationHstry")]
[Index("TreatmentStartTime", Name = "XIE2RadiationHstry")]
[Index("TreatmentEndTime", Name = "XIE3RadiationHstry")]
[Index("TreatmentRecordSer", Name = "XIF1RadiationHstry")]
[Index("RadiationSer", Name = "XIF2RadiationHstry")]
public partial class RadiationHstry
{
    [Key]
    public long RadiationHstrySer { get; set; }

    public long TreatmentRecordSer { get; set; }

    [StringLength(32)]
    public string RadiationHstryType { get; set; } = null!;

    [StringLength(16)]
    public string? TreatmentDeliveryType { get; set; }

    public long RadiationSer { get; set; }

    [StringLength(16)]
    public string RadiationId { get; set; } = null!;

    [StringLength(64)]
    public string? RadiationName { get; set; }

    public int? RadiationNumber { get; set; }

    [StringLength(64)]
    public string? TechniqueLabel { get; set; }

    [StringLength(16)]
    public string? RadiationType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TreatmentStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TreatmentEndTime { get; set; }

    public double? TreatmentTime { get; set; }

    public byte TreatmentTimeOverrideFlag { get; set; }

    [StringLength(16)]
    public string TerminationStatus { get; set; } = null!;

    public int FractionNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    [StringLength(255)]
    public string? ApprovalUserName { get; set; }

    [StringLength(64)]
    public string? UserName1 { get; set; }

    [StringLength(32)]
    public string? UserName2 { get; set; }

    [StringLength(32)]
    public string? UserName3 { get; set; }

    public int OverrideFlag { get; set; }

    public int? NoOfImage { get; set; }

    public int PrintFlag { get; set; }

    [Column("RVFlag")]
    public byte Rvflag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public string? HistoryNote { get; set; }

    public string? MachineNote { get; set; }

    public string? FieldSetupNote { get; set; }

    [StringLength(64)]
    public string? BeamOffCode { get; set; }

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual ICollection<ActCaptTreatment> ActCaptTreatment { get; set; } = new List<ActCaptTreatment>();

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual BrachyFieldHstry? BrachyFieldHstry { get; set; }

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual ICollection<ChartQatreatment> ChartQatreatment { get; set; } = new List<ChartQatreatment>();

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual ExternalFieldCommonHstry? ExternalFieldCommonHstry { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("RadiationHstry")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;

    [InverseProperty("RadiationHstrySerNavigation")]
    public virtual ICollection<RefPointHstry> RefPointHstry { get; set; } = new List<RefPointHstry>();

    [ForeignKey("TreatmentRecordSer")]
    [InverseProperty("RadiationHstry")]
    public virtual TreatmentRecord TreatmentRecordSerNavigation { get; set; } = null!;
}
