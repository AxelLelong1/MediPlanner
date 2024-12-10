using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("TreatmentHstryModel", Schema = "DWH")]
public partial class TreatmentHstryModel
{
    public long? PatientSer { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    public long? CourseSer { get; set; }

    [StringLength(16)]
    public string? CourseId { get; set; }

    public long? PlanSetupSer { get; set; }

    [StringLength(16)]
    public string? PlanSetupId { get; set; }

    public long? RadiationSer { get; set; }

    [StringLength(16)]
    public string? RadiationId { get; set; }

    [StringLength(64)]
    public string? RadiationName { get; set; }

    [StringLength(64)]
    public string? ToleranceName { get; set; }

    [StringLength(64)]
    public string? PlanSetupStatus { get; set; }

    [StringLength(16)]
    public string? Scale { get; set; }

    [StringLength(16)]
    public string? MachineId { get; set; }

    public int? Energy { get; set; }

    [StringLength(16)]
    public string? BolusId { get; set; }

    public double? IsoCenterPositionX { get; set; }

    public double? IsoCenterPositionY { get; set; }

    public double? IsoCenterPositionZ { get; set; }

    [StringLength(254)]
    public string? SetupNote { get; set; }

    [StringLength(16)]
    public string? FieldTechnique { get; set; }

    public int? FieldType { get; set; }

    [Column("PlannedMU")]
    public double? PlannedMu { get; set; }

    public double? TreatmentTime { get; set; }

    [StringLength(1024)]
    public string? HistoryNote { get; set; }

    [Column("DeliveredMU")]
    public double? DeliveredMu { get; set; }

    public double? DoseDeliveredToPrimaryRefPoint { get; set; }

    public int? FractionNumber { get; set; }

    public long? TreatmentRecordSer { get; set; }

    public double? CouchLat { get; set; }

    public byte? CouchLatOverrideFlag { get; set; }

    public double? CouchLatPlanned { get; set; }

    public double? CouchLng { get; set; }

    public byte? CouchLngOverrideFlag { get; set; }

    public double? CouchLngPlanned { get; set; }

    public double? CouchVrt { get; set; }

    public byte? CouchVrtOverrideFlag { get; set; }

    public double? CouchVrtPlanned { get; set; }

    public byte? EnergyModeOverrideFlag { get; set; }

    public byte? MetersetOverrideFlag { get; set; }

    public int? NominalEnergy { get; set; }

    [Column("PFFlag")]
    [StringLength(1)]
    public string? Pfflag { get; set; }

    [Column("PFMUSubFlag")]
    public byte? PfmusubFlag { get; set; }

    [Column("PIFlag")]
    [StringLength(1)]
    public string? Piflag { get; set; }

    public byte? PatSupPitchOverrideFlag { get; set; }

    public byte? PatSupRollOverrideFlag { get; set; }

    public double? PatSupportPitchAngle { get; set; }

    public double? PatSupportRollAngle { get; set; }

    public double? PatientSupportAngle { get; set; }

    public byte? PatientSupportAngleOverFlag { get; set; }

    [Column("SSD")]
    public double? Ssd { get; set; }

    [Column("SSDOverrideFlag")]
    public byte? SsdoverrideFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentRecordDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentEndTime { get; set; }

    public long? RadiationHstrySer { get; set; }

    public long? ToleranceSer { get; set; }

    public long? EnergyModeSer { get; set; }

    [StringLength(16)]
    public string? ActualCollMode { get; set; }

    [StringLength(16)]
    public string? BeamCurrentModulationId { get; set; }

    [StringLength(64)]
    public string? BeamModifiersSet { get; set; }

    [StringLength(64)]
    public string? BeamOffCode { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    public byte? CollModeOverrideFlag { get; set; }

    public double? CollRtn { get; set; }

    public byte? CollRtnOverrideFlag { get; set; }

    public double? CollX1 { get; set; }

    [Column("CollX1OverrideFlag")]
    public byte? CollX1overrideFlag { get; set; }

    public double? CollX2 { get; set; }

    [Column("CollX2OverrideFlag")]
    public byte? CollX2overrideFlag { get; set; }

    public double? CollY1 { get; set; }

    [Column("CollY1OverrideFlag")]
    public byte? CollY1overrideFlag { get; set; }

    public double? CollY2 { get; set; }

    [Column("CollY2OverrideFlag")]
    public byte? CollY2overrideFlag { get; set; }

    public double? CouchCorrectionLat { get; set; }

    public double? CouchCorrectionLng { get; set; }

    public double? CouchCorrectionVrt { get; set; }

    public byte? DoseRateOverrideFlag { get; set; }

    public byte? GantryRtnOverrideFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    public int? LastCorrelatedEventNumber { get; set; }

    public int? LastEventNumber { get; set; }

    public int? LastFractionNumber { get; set; }

    public int? LastFractionNumberCalc { get; set; }

    public byte? MachOverrideFlag { get; set; }

    [Column("MUpDeg")]
    public double? MupDeg { get; set; }

    [Column("MUpDegOverrideFlag")]
    public byte? MupDegOverrideFlag { get; set; }

    public byte? NumOfPaintOverrideFlag { get; set; }

    public double? OffPlaneAngle { get; set; }

    public byte? OverrideFlag { get; set; }

    [StringLength(32)]
    public string? RadiationHstryType { get; set; }

    public double? SnoutPosition { get; set; }

    public byte? SnoutPosOverrideFlag { get; set; }

    [Column("SOBPWidth")]
    public double? Sobpwidth { get; set; }

    public double? StopAngle { get; set; }

    [Column("StructureSetUID")]
    [StringLength(64)]
    public string? StructureSetUid { get; set; }

    public byte? TableTopEccAngleOverFlag { get; set; }

    public double? TableTopEccentricAngle { get; set; }

    [Column("TreatmentRecordSOPClassSer")]
    public long? TreatmentRecordSopclassSer { get; set; }

    [Column("TreatmentRecordUID")]
    [StringLength(64)]
    public string? TreatmentRecordUid { get; set; }

    public byte? TreatmentTimeOverrideFlag { get; set; }

    public double? WedgeAngle { get; set; }

    public double? WedgeAngle2 { get; set; }

    public double? WedgeDirection { get; set; }

    public double? WedgeDirection2 { get; set; }

    public byte? WedgeDoseOverrideFlag { get; set; }

    public int? WedgeNumber1 { get; set; }

    public int? WedgeNumber2 { get; set; }

    public int? ActualDoseRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    public double? DistalEndEnergy { get; set; }

    public int? CorrelatedEventNumber { get; set; }

    public int? EventNumber { get; set; }

    [Column("FieldMUActual")]
    public double? FieldMuactual { get; set; }

    [StringLength(1024)]
    public string? FieldSetupNote { get; set; }

    [StringLength(16)]
    public string? FieldStatus { get; set; }

    public int? IsImage { get; set; }

    public int? NoFractions { get; set; }

    public int? NoOfFractions { get; set; }

    public int? NoOfImage { get; set; }

    public int? PrintFlag { get; set; }

    [Column("PSACorrection")]
    public double? Psacorrection { get; set; }

    public int? RadiationNumber { get; set; }

    [StringLength(16)]
    public string? RadiationType { get; set; }

    [StringLength(16)]
    public string? RecordStatus { get; set; }

    [Column("RVFlag")]
    public byte? Rvflag { get; set; }

    public long? SeriesSer { get; set; }

    [StringLength(64)]
    public string? UserName1 { get; set; }

    [StringLength(255)]
    public string? UserName2 { get; set; }

    [StringLength(255)]
    public string? UserName3 { get; set; }

    public long? RefPointSer { get; set; }

    [StringLength(16)]
    public string? Technique { get; set; }

    [StringLength(64)]
    public string? TechniqueLabel { get; set; }

    [StringLength(16)]
    public string? TreatmentDeliveryType { get; set; }

    public int? IntendedNumOfPaintings { get; set; }

    [Column("FirstRTPlanSer")]
    public long? FirstRtplanSer { get; set; }

    public long? FirstPlanSetupSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    [Column("RTPlanAge")]
    public int? RtplanAge { get; set; }

    public long? ActualMachineSer { get; set; }

    [StringLength(64)]
    public string? ActualMachineAuthorization { get; set; }

    [StringLength(16)]
    public string? AddOnId1 { get; set; }

    [StringLength(16)]
    public string? AddOnId10 { get; set; }

    [StringLength(16)]
    public string? AddOnId2 { get; set; }

    [StringLength(16)]
    public string? AddOnId3 { get; set; }

    [StringLength(16)]
    public string? AddOnId4 { get; set; }

    [StringLength(16)]
    public string? AddOnId5 { get; set; }

    [StringLength(16)]
    public string? AddOnId6 { get; set; }

    [StringLength(16)]
    public string? AddOnId7 { get; set; }

    [StringLength(16)]
    public string? AddOnId8 { get; set; }

    [StringLength(16)]
    public string? AddOnId9 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType1 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType10 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType2 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType3 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType4 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType5 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType6 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType7 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType8 { get; set; }

    [StringLength(64)]
    public string? AddOnSubType9 { get; set; }

    [StringLength(30)]
    public string? AddOnType1 { get; set; }

    [StringLength(30)]
    public string? AddOnType10 { get; set; }

    [StringLength(30)]
    public string? AddOnType2 { get; set; }

    [StringLength(30)]
    public string? AddOnType3 { get; set; }

    [StringLength(30)]
    public string? AddOnType4 { get; set; }

    [StringLength(30)]
    public string? AddOnType5 { get; set; }

    [StringLength(30)]
    public string? AddOnType6 { get; set; }

    [StringLength(30)]
    public string? AddOnType7 { get; set; }

    [StringLength(30)]
    public string? AddOnType8 { get; set; }

    [StringLength(30)]
    public string? AddOnType9 { get; set; }

    [StringLength(255)]
    public string? ApprovalUserName { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    public double? FixLightAzimuthAngle { get; set; }

    public double? FixLightPolarPos { get; set; }

    public double? GantryRtn { get; set; }

    [StringLength(16)]
    public string? GantryRtnDirection { get; set; }

    [StringLength(16)]
    public string? GantryRtnExt { get; set; }

    [StringLength(1024)]
    public string? MachineNote { get; set; }

    [Column("PlanSOPClassSer")]
    public long? PlanSopclassSer { get; set; }

    public long? ResourceSer { get; set; }

    [StringLength(16)]
    public string? TerminationStatus { get; set; }

    public double? WedgeDose { get; set; }

    public long? TechniqueSer { get; set; }

    public long? StructureSer { get; set; }

    [StringLength(16)]
    public string? PlannedGantryRtnExt { get; set; }

    [StringLength(16)]
    public string? PlannedCollMode { get; set; }

    public double? PlannedWedgeDose { get; set; }

    public double? DoseDeliveredPerFraction { get; set; }
}
