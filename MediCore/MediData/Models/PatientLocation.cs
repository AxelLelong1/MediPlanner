using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", Name = "XIF648PatientLocation")]
[Index("ScheduledActivitySer", Name = "XIF763PatientLocation")]
public partial class PatientLocation
{
    [Key]
    public long PatientLocationSer { get; set; }

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

    [InverseProperty("PatientLocationSerNavigation")]
    public virtual ICollection<PatientLocationMh> PatientLocationMh { get; set; } = new List<PatientLocationMh>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("PatientLocation")]
    public virtual Venue? ResourceSerNavigation { get; set; }

    [ForeignKey("ScheduledActivitySer")]
    [InverseProperty("PatientLocation")]
    public virtual ScheduledActivity ScheduledActivitySerNavigation { get; set; } = null!;
}
