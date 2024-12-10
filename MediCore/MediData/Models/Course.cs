using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", "CourseSer", Name = "XIE1Course")]
[Index("PatientSer", "CourseId", Name = "XIE2Course")]
[Index("HstryDateTime", Name = "XIE3Course")]
public partial class Course
{
    [Key]
    public long CourseSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [StringLength(16)]
    public string ClinicalStatus { get; set; } = null!;

    [StringLength(255)]
    public string? CompletedByUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDateTime { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(254)]
    public string? ClinicalProtocolDir { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<ActivityCapture> ActivityCapture { get; set; } = new List<ActivityCapture>();

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<CourseDiagnosis> CourseDiagnosis { get; set; } = new List<CourseDiagnosis>();

    [InverseProperty("CourseSerNavigation")]
    public virtual CoursePrintInfo? CoursePrintInfo { get; set; }

    [InverseProperty("CourseSerNavigation")]
    public virtual CoursePrintInfo1? CoursePrintInfo1 { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("Course")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<PhysicianIntent> PhysicianIntent { get; set; } = new List<PhysicianIntent>();

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<PlanSum> PlanSum { get; set; } = new List<PlanSum>();

    [InverseProperty("RelatedCourseSerNavigation")]
    public virtual ICollection<Series> Series { get; set; } = new List<Series>();

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<Session> Session { get; set; } = new List<Session>();

    [InverseProperty("RelatedCourseSerNavigation")]
    public virtual ICollection<Study> Study { get; set; } = new List<Study>();

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<Template> Template { get; set; } = new List<Template>();

    [InverseProperty("CourseSerNavigation")]
    public virtual ICollection<TreatmentPhase> TreatmentPhase { get; set; } = new List<TreatmentPhase>();
}
