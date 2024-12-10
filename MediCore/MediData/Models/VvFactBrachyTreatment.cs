using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactBrachyTreatment
{
    [StringLength(32)]
    public string RadiationHstryType { get; set; } = null!;

    [StringLength(16)]
    public string? TreatmentDeliveryType { get; set; }

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

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public string? HistoryNote { get; set; }

    public string? MachineNote { get; set; }

    public string? FieldSetupNote { get; set; }

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

    [StringLength(64)]
    public string? TreatmentRecordActualMachineAuthorization { get; set; }

    public byte TreatmentRecordMachOverrideFlag { get; set; }

    [StringLength(255)]
    public string TreatmentRecordHstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TreatmentRecordHstryDateTime { get; set; }

    [StringLength(32)]
    public string? TreatmentRecordHstryTaskName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentRecordTreatmentRecordDateTime { get; set; }

    public int? TreatmentRecordNoOfFractions { get; set; }

    [StringLength(255)]
    public string? CourseByUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CourseCompletedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CourseStartDateTime { get; set; }

    [StringLength(16)]
    public string CourseClinicalStatus { get; set; } = null!;

    public double? PrescribedPercentage { get; set; }

    public double? PrescribedDose { get; set; }

    [StringLength(16)]
    public string PlanTreatmentType { get; set; } = null!;

    public double? ActualDose { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrCourseSer")]
    public long CtrCourseSer { get; set; }

    [Column("ctrPlanSetupSer")]
    public long CtrPlanSetupSer { get; set; }

    [Column("ctrRTPlanSer")]
    public long CtrRtplanSer { get; set; }

    [Column("ctrRefPointSer")]
    public long CtrRefPointSer { get; set; }

    [Column("ctrRefPointHstrySer")]
    public long CtrRefPointHstrySer { get; set; }

    [Column("ctrActualMachineSer")]
    public long? CtrActualMachineSer { get; set; }

    [Column("ctrPlannedMachineSer")]
    public long? CtrPlannedMachineSer { get; set; }

    [Column("ctrTreatmentRecordSer")]
    public long CtrTreatmentRecordSer { get; set; }

    [Column("ctrRadiationSer")]
    public long CtrRadiationSer { get; set; }

    [Column("ctrRadiationHstrySer")]
    public long CtrRadiationHstrySer { get; set; }
}
