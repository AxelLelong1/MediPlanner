using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvTreatmentRecord
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public long CourseSer { get; set; }

    [StringLength(16)]
    public string PlanSetupId { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    public long TreatmentRecordSer { get; set; }

    public long PatientSer { get; set; }

    public long SeriesSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }

    [Column("PlanSOPClassSer")]
    public long PlanSopclassSer { get; set; }

    [Column("TreatmentRecordSOPClassSer")]
    public long TreatmentRecordSopclassSer { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    [Column("TreatmentRecordUID")]
    [StringLength(64)]
    public string TreatmentRecordUid { get; set; } = null!;

    [StringLength(254)]
    public string? FileName { get; set; }

    public long? ActualMachineSer { get; set; }

    [StringLength(64)]
    public string? ActualMachineAuthorization { get; set; }

    public byte MachOverrideFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("StructureSetUID")]
    [StringLength(64)]
    public string? StructureSetUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentRecordDateTime { get; set; }

    public int? NoOfFractions { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }
}
