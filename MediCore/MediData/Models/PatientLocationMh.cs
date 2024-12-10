using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PatientLocationSer", "PatientLocationRevCount")]
[Table("PatientLocationMH")]
[Index("ScheduledActivitySer", "ScheduledActivityRevCount", Name = "XIE1PatientLocationMH")]
public partial class PatientLocationMh
{
    [Key]
    public long PatientLocationSer { get; set; }

    [Key]
    public int PatientLocationRevCount { get; set; }

    public long ScheduledActivitySer { get; set; }

    public int ScheduledActivityRevCount { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public long? ResourceSer { get; set; }

    public int CheckedInFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArrivalDateTime { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientLocationSer")]
    [InverseProperty("PatientLocationMh")]
    public virtual PatientLocation PatientLocationSerNavigation { get; set; } = null!;
}
