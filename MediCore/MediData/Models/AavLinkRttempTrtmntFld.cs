using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class AavLinkRttempTrtmntFld
{
    [Column("SPID")]
    public long Spid { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [Column("CourseID")]
    [StringLength(16)]
    public string? CourseId { get; set; }

    [Column("PlanSetupID")]
    [StringLength(16)]
    public string? PlanSetupId { get; set; }

    [Column("FieldID")]
    [StringLength(16)]
    public string? FieldId { get; set; }

    [StringLength(64)]
    public string? FieldName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(16)]
    public string? MachineId { get; set; }

    [StringLength(16)]
    public string? ToleranceId { get; set; }

    [StringLength(64)]
    public string? ToleranceTableName { get; set; }

    [StringLength(16)]
    public string? Scale { get; set; }

    [StringLength(16)]
    public string? TechniqueId { get; set; }

    [StringLength(16)]
    public string? EnergyMode { get; set; }

    [Column("MLCFlag")]
    public int? Mlcflag { get; set; }

    [StringLength(254)]
    public string? SetupNote { get; set; }

    [StringLength(16)]
    public string? CollMode { get; set; }

    [Column("MU")]
    public int? Mu { get; set; }

    public double? TreatmentTime { get; set; }

    [Column("SSD")]
    public double? Ssd { get; set; }

    public double? StopAng { get; set; }

    [StringLength(16)]
    public string? StopAngE { get; set; }

    [Column("MUdeg")]
    public double? Mudeg { get; set; }

    public double? CollRtn { get; set; }

    public double? CollRtnM { get; set; }

    public double? GantryRtn { get; set; }

    [StringLength(16)]
    public string? GantryRtnE { get; set; }

    [StringLength(16)]
    public string? GantryRtnExt { get; set; }

    public double? CollY1 { get; set; }

    public double? CollY2 { get; set; }

    public double? CollX1 { get; set; }

    public double? CollX2 { get; set; }

    public double? CouchVrt { get; set; }

    public double? CouchVrtM { get; set; }

    public double? CouchLng { get; set; }

    public double? CouchLngM { get; set; }

    public double? CouchLat { get; set; }

    public double? CouchLatM { get; set; }

    public double? CouchRtn { get; set; }

    public double? CouchRtnM { get; set; }

    [StringLength(16)]
    public string? AddOnId1 { get; set; }

    [StringLength(30)]
    public string? AddOnType1 { get; set; }

    [StringLength(64)]
    public string? SlotName1 { get; set; }

    [StringLength(16)]
    public string? AddOnId2 { get; set; }

    [StringLength(30)]
    public string? AddOnType2 { get; set; }

    [StringLength(64)]
    public string? SlotName2 { get; set; }

    [StringLength(16)]
    public string? AddOnId3 { get; set; }

    [StringLength(30)]
    public string? AddOnType3 { get; set; }

    [StringLength(64)]
    public string? SlotName3 { get; set; }

    [StringLength(16)]
    public string? AddOnId4 { get; set; }

    [StringLength(30)]
    public string? AddOnType4 { get; set; }

    [StringLength(64)]
    public string? SlotName4 { get; set; }

    [StringLength(16)]
    public string? AddOnId5 { get; set; }

    [StringLength(30)]
    public string? AddOnType5 { get; set; }

    [StringLength(64)]
    public string? SlotName5 { get; set; }

    [StringLength(16)]
    public string? AddOnId6 { get; set; }

    [StringLength(30)]
    public string? AddOnType6 { get; set; }

    [StringLength(64)]
    public string? SlotName6 { get; set; }

    public int? TreatmentFlag { get; set; }

    public int? PtTreatedFlag { get; set; }

    public int? DoseRate { get; set; }

    public double? WedgeDose { get; set; }

    public long? FieldSer { get; set; }

    public long? FieldRevCount { get; set; }

    [Column("MUpGy")]
    public double? MupGy { get; set; }

    public double? TempDose { get; set; }

    [Column("WDProcessFlag")]
    public int? WdprocessFlag { get; set; }
}
