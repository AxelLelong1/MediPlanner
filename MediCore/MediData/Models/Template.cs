using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DerivedFromSer", Name = "XIF517Template")]
[Index("PatientSer", Name = "XIF552Template")]
[Index("DepartmentSer", Name = "XIF553Template")]
[Index("CourseSer", Name = "XIF599Template")]
[Index("ResourceSer", Name = "XIF671Template")]
[Index("PayorSer", Name = "XIF672Template")]
[Index("DiagnosisStageSer", Name = "XIF673Template")]
public partial class Template
{
    [Key]
    public long TemplateSer { get; set; }

    public int TemplateRevCount { get; set; }

    public long? PatientSer { get; set; }

    public long? DiagnosisStageSer { get; set; }

    public long? PayorSer { get; set; }

    public long? ResourceSer { get; set; }

    public long? DepartmentSer { get; set; }

    public long? DerivedFromSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("TemplateID")]
    [StringLength(64)]
    public string? TemplateId { get; set; }

    public long? CourseSer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public int DefaultFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("CourseSer")]
    [InverseProperty("Template")]
    public virtual Course? CourseSerNavigation { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("Template")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("DerivedFromSer")]
    [InverseProperty("InverseDerivedFromSerNavigation")]
    public virtual Template? DerivedFromSerNavigation { get; set; }

    [ForeignKey("DiagnosisStageSer")]
    [InverseProperty("Template")]
    public virtual DiagnosisStage? DiagnosisStageSerNavigation { get; set; }

    [InverseProperty("DerivedFromSerNavigation")]
    public virtual ICollection<Template> InverseDerivedFromSerNavigation { get; set; } = new List<Template>();

    [ForeignKey("PatientSer")]
    [InverseProperty("Template")]
    public virtual Patient? PatientSerNavigation { get; set; }

    [ForeignKey("PayorSer")]
    [InverseProperty("Template")]
    public virtual Payor? PayorSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Template")]
    public virtual Resource? ResourceSerNavigation { get; set; }

    [InverseProperty("TemplateSerNavigation")]
    public virtual ICollection<TemplateCycle> TemplateCycle { get; set; } = new List<TemplateCycle>();

    [InverseProperty("TemplateSerNavigation")]
    public virtual ICollection<TemplateDiagnosis> TemplateDiagnosis { get; set; } = new List<TemplateDiagnosis>();

    [InverseProperty("TemplateSerNavigation")]
    public virtual ICollection<TemplateMh> TemplateMh { get; set; } = new List<TemplateMh>();
}
