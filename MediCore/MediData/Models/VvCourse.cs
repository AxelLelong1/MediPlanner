using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvCourse
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

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
}
