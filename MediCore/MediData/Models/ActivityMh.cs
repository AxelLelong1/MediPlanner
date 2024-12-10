using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivitySer", "ActivityRevCount")]
[Table("ActivityMH")]
[Index("ActivityCategorySer", "ActivityCode", "ActivityRevCount", Name = "XAK1ActivityMH", IsUnique = true)]
public partial class ActivityMh
{
    [Key]
    public long ActivitySer { get; set; }

    [Key]
    public int ActivityRevCount { get; set; }

    public long ActivityCategorySer { get; set; }

    [StringLength(64)]
    public string ActivityCode { get; set; } = null!;

    [StringLength(32)]
    public string ActivityType { get; set; } = null!;

    public long? DerivedFromActivitySer { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public long? ResourceGroupSer { get; set; }

    public int? DefaultDuration { get; set; }

    public int ExclusiveFlag { get; set; }

    public int? NotificationPriorTime { get; set; }

    public int AssignableFlag { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    [MaxLength(4)]
    public byte[]? ForeGroundColor { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Icon { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("DICOMCodeValueSer")]
    public long? DicomcodeValueSer { get; set; }

    public int NotificationPriorTimeFlag { get; set; }

    public long? EscalationGroupSer { get; set; }

    public long? TreatmentCycleSer { get; set; }

    public int ReviewFlag { get; set; }

    [Column("UpdCPResourceGroupSer")]
    public long? UpdCpresourceGroupSer { get; set; }

    [Column("UpdCPEscalationGroupSer")]
    public long? UpdCpescalationGroupSer { get; set; }

    public int AutoGenerateFlag { get; set; }

    public int NoAutoPostFlag { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityMh")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;
}
