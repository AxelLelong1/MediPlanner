using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("FieldModel", Schema = "DWH")]
public partial class FieldModel
{
    public double? CollimatorX1 { get; set; }

    public double? CollimatorX2 { get; set; }

    public double? CollimatorY1 { get; set; }

    public double? CollimatorY2 { get; set; }

    public double? CouchLat { get; set; }

    public double? CouchLng { get; set; }

    public double? CouchVrt { get; set; }

    [StringLength(16)]
    public string? CourseId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public int? DoseRate { get; set; }

    public int? Energy { get; set; }

    [StringLength(16)]
    public string? FieldTechnique { get; set; }

    public int? SetupFieldFlag { get; set; }

    public double? GantryRotation { get; set; }

    public int? GatingFlag { get; set; }

    public double? IsoCenterPositionX { get; set; }

    public double? IsoCenterPositionY { get; set; }

    public double? IsoCenterPositionZ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastTreatmentDate { get; set; }

    [StringLength(16)]
    public string? MachineId { get; set; }

    [StringLength(16)]
    public string? MachineScale { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    public double? PatientSupportAngle { get; set; }

    public double? PlannedMu { get; set; }

    [StringLength(16)]
    public string? PlanSetupId { get; set; }

    [StringLength(16)]
    public string? PrimaryDosimeterUnit { get; set; }

    [StringLength(16)]
    public string? RadiationId { get; set; }

    [StringLength(64)]
    public string? RadiationName { get; set; }

    [StringLength(16)]
    public string? RadiationType { get; set; }

    [StringLength(254)]
    public string? SetupNote { get; set; }

    [Column("SSD")]
    public double? Ssd { get; set; }

    public double? StopAngle { get; set; }

    [StringLength(16)]
    public string? ToleranceId { get; set; }

    [StringLength(64)]
    public string? ToleranceTable { get; set; }

    [StringLength(64)]
    public string? TreatmentApprovalState { get; set; }

    [StringLength(16)]
    public string? AddOnId { get; set; }

    [StringLength(30)]
    public string? AddOnType { get; set; }

    public double? TotalNumberOfFractionsPlanned { get; set; }

    public double? NoFractionsTreated { get; set; }

    public double? FixLightAzimuthAngle { get; set; }

    public double? FixLightPolarPos { get; set; }

    [StringLength(16)]
    public string? GantryRtnDirection { get; set; }

    [StringLength(16)]
    public string? GantryRtnExt { get; set; }

    public double? WedgeDose { get; set; }

    public double? RefDose { get; set; }

    [Column("MLCPlanType")]
    [StringLength(30)]
    public string? MlcplanType { get; set; }

    [StringLength(32)]
    public string? IndexParameterType { get; set; }

    [Column("MURounded")]
    public double? Murounded { get; set; }

    public long? StructureSetSer { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    public double? CollRtn { get; set; }

    public double? TreatmentTime { get; set; }

    public long? AddOnSer { get; set; }

    public long? RadiationSer { get; set; }

    public long? TechinqueSer { get; set; }

    public long? ToleranceSer { get; set; }

    public long? RefImageSer { get; set; }

    public long? PlanSetupSer { get; set; }

    public long? PatientSer { get; set; }

    public long? MachineSer { get; set; }

    public long? EnergyModeSer { get; set; }

    public long? CourseSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }

    public long? TechniqueSer { get; set; }

    [Column("IMRTOrRapidArc")]
    [StringLength(16)]
    public string? ImrtorRapidArc { get; set; }
}
