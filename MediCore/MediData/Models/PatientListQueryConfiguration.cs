using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AppUserSer", "QueryId", "QueryType", "IsShared", Name = "IX_PatientListQueryConfiguration")]
public partial class PatientListQueryConfiguration
{
    [Key]
    public long PatientListQueryConfigurationSer { get; set; }

    public int? QueryId { get; set; }

    [StringLength(256)]
    public string QueryName { get; set; } = null!;

    public string? QueryText { get; set; }

    public long? ActivitySer { get; set; }

    [Column("WorkspaceID")]
    [StringLength(32)]
    public string? WorkspaceId { get; set; }

    public short QueryType { get; set; }

    public int IsShared { get; set; }

    public long AppUserSer { get; set; }

    public short? DateRangeValue { get; set; }

    public int? DateRangeType { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("PatientListQueryConfiguration")]
    public virtual Activity? ActivitySerNavigation { get; set; }

    [ForeignKey("AppUserSer")]
    [InverseProperty("PatientListQueryConfiguration")]
    public virtual AppUser AppUserSerNavigation { get; set; } = null!;
}
