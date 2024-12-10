using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("CourseSer", Name = "XIF1PhysicianIntent")]
public partial class PhysicianIntent
{
    [Key]
    public long PhysicianIntentSer { get; set; }

    [Column("PhysicianIntentUID")]
    [StringLength(64)]
    public string? PhysicianIntentUid { get; set; }

    [StringLength(64)]
    public string TreatmentIntentType { get; set; } = null!;

    public long? DiagnosisSer { get; set; }

    public long CourseSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("CourseSer")]
    [InverseProperty("PhysicianIntent")]
    public virtual Course CourseSerNavigation { get; set; } = null!;
}
