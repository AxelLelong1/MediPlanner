using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("StudyUid", Name = "XAK1Study", IsUnique = true)]
[Index("PatientSer", "StudyId", Name = "XIE1Study")]
[Index("PatientSer", "StudySer", Name = "XIE3Study")]
[Index("RelatedCourseSer", Name = "XIF355Study")]
public partial class Study
{
    [Key]
    public long StudySer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string StudyId { get; set; } = null!;

    [StringLength(64)]
    public string? StudyName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(255)]
    public string? ReferringPhysicianName { get; set; }

    [Column("StudyUID")]
    [StringLength(64)]
    public string StudyUid { get; set; } = null!;

    [StringLength(16)]
    public string? AccessionNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? RelatedCourseSer { get; set; }

    public long? RelatedDiagnosisSer { get; set; }

    [InverseProperty("StudySerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstance { get; set; } = new List<ActivityInstance>();

    [ForeignKey("PatientSer")]
    [InverseProperty("Study")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("RelatedCourseSer")]
    [InverseProperty("Study")]
    public virtual Course? RelatedCourseSerNavigation { get; set; }

    [InverseProperty("StudySerNavigation")]
    public virtual ICollection<Series> Series { get; set; } = new List<Series>();
}
