using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ScheduledTaskSer", "PatientSer")]
[Table("LTAScheduledTaskPatient")]
[Index("PatientSer", Name = "XIF819LTAScheduledTaskPatient")]
public partial class LtascheduledTaskPatient
{
    [Key]
    public long ScheduledTaskSer { get; set; }

    [Key]
    public long PatientSer { get; set; }

    [StringLength(32)]
    public string Status { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("LtascheduledTaskPatient")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("ScheduledTaskSer")]
    [InverseProperty("LtascheduledTaskPatient")]
    public virtual LtascheduledTask ScheduledTaskSerNavigation { get; set; } = null!;
}
