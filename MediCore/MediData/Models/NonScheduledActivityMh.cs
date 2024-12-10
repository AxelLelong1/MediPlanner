using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("NonScheduledActivitySer", "NonScheduledActivityRevCount")]
[Table("NonScheduledActivityMH")]
[Index("ActivityInstanceSer", "ActivityInstanceRevCount", Name = "XIE1NonScheduledActivityMH")]
public partial class NonScheduledActivityMh
{
    [Key]
    public long NonScheduledActivitySer { get; set; }

    [Key]
    public int NonScheduledActivityRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long? PatientSer { get; set; }

    public long? CreatedByResourceSer { get; set; }

    [StringLength(255)]
    public string CreatedByUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("UID")]
    [StringLength(64)]
    public string Uid { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DueDateTime { get; set; }

    [StringLength(64)]
    public string? NonScheduledActivityCode { get; set; }

    [StringLength(64)]
    public string? Priority { get; set; }

    [StringLength(254)]
    public string? ActivityNote { get; set; }

    public long? RecurrenceRuleSer { get; set; }

    [StringLength(255)]
    public string? ReadByAppUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadByDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int WorkFlowActiveFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletionDate { get; set; }

    [ForeignKey("NonScheduledActivitySer")]
    [InverseProperty("NonScheduledActivityMh")]
    public virtual NonScheduledActivity NonScheduledActivitySerNavigation { get; set; } = null!;
}
