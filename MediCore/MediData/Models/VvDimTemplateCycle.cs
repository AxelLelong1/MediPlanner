using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimTemplateCycle
{
    public long TemplateSer { get; set; }

    public int TemplateRevCount { get; set; }

    public long? PatientSer { get; set; }

    public long? DiagnosisStageSer { get; set; }

    public long? PayorSer { get; set; }

    public long? ResourceSer { get; set; }

    public long? DepartmentSer { get; set; }

    public long? DerivedFromSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TemplateCreationDate { get; set; }

    [Column("TemplateID")]
    [StringLength(64)]
    public string? TemplateId { get; set; }

    public long? CourseSer { get; set; }

    [StringLength(16)]
    public string TemplateObjectStatus { get; set; } = null!;

    public int DefaultFlag { get; set; }

    [StringLength(254)]
    public string? TemplateComment { get; set; }

    public long TemplateCycleSer { get; set; }

    public int TemplateCycleRevCount { get; set; }

    [StringLength(16)]
    public string TemplateCycleObjectStatus { get; set; } = null!;

    [StringLength(254)]
    public string? TemplateCycleComment { get; set; }

    public long CycleSer { get; set; }

    [StringLength(32)]
    public string? TreatmentCycle { get; set; }

    [StringLength(64)]
    public string? DiagnosisStage { get; set; }

    [StringLength(16)]
    public string? DiagnosisCode { get; set; }

    [StringLength(64)]
    public string? DiagnosisTableName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TemplateCycleHistoryDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TemplateHistoryDateTime { get; set; }

    [StringLength(255)]
    public string TemplateCycleHstryUserName { get; set; } = null!;

    [StringLength(255)]
    public string TemplateHstryUserName { get; set; } = null!;
}
