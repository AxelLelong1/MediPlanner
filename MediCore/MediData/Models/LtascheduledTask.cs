using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("LTAScheduledTask")]
[Index("ArchiveLocationSer", Name = "XIF820LTAScheduledTask")]
public partial class LtascheduledTask
{
    [Key]
    public long ScheduledTaskSer { get; set; }

    [StringLength(64)]
    public string? Name { get; set; }

    [StringLength(32)]
    public string Status { get; set; } = null!;

    public long ArchiveLocationSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(254)]
    public string? StatusDescription { get; set; }

    [ForeignKey("ArchiveLocationSer")]
    [InverseProperty("LtascheduledTask")]
    public virtual ArchiveLocation ArchiveLocationSerNavigation { get; set; } = null!;

    [InverseProperty("ScheduledTaskSerNavigation")]
    public virtual ICollection<LtascheduledTaskPatient> LtascheduledTaskPatient { get; set; } = new List<LtascheduledTaskPatient>();
}
