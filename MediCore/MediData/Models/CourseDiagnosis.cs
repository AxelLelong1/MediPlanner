using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CourseSer", "DiagnosisSer")]
[Index("DiagnosisSer", "CourseSer", Name = "XAKCourseDiagnosis", IsUnique = true)]
public partial class CourseDiagnosis
{
    [Key]
    public long CourseSer { get; set; }

    [Key]
    public long DiagnosisSer { get; set; }

    public long? CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("CourseSer")]
    [InverseProperty("CourseDiagnosis")]
    public virtual Course CourseSerNavigation { get; set; } = null!;
}
