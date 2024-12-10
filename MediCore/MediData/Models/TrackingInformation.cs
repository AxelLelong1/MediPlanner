using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ArchiveLocationSer", Name = "XIF724TrackingInformation")]
[Index("PatientSer", Name = "XIF726TrackingInformation")]
public partial class TrackingInformation
{
    [Key]
    public long TrackingInformationSer { get; set; }

    public long PatientSer { get; set; }

    public long ArchiveLocationSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArchiveDate { get; set; }

    [StringLength(255)]
    public string? ArchiveUser { get; set; }

    [StringLength(254)]
    public string? ArchiveNote { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PurgeDate { get; set; }

    [StringLength(255)]
    public string? PurgeUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RestoreDate { get; set; }

    [StringLength(255)]
    public string? RestoreUser { get; set; }

    [StringLength(254)]
    public string? RestoreNote { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RemoveDate { get; set; }

    [StringLength(255)]
    public string? RemoveUser { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [Column("LTArchiveVersion")]
    [StringLength(32)]
    public string LtarchiveVersion { get; set; } = null!;

    [StringLength(64)]
    public string? DocDeleteStatus { get; set; }

    [StringLength(64)]
    public string? SchChrgDeleteStatus { get; set; }

    [StringLength(64)]
    public string TrackingStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ArchiveLocationSer")]
    [InverseProperty("TrackingInformation")]
    public virtual ArchiveLocation ArchiveLocationSerNavigation { get; set; } = null!;

    [InverseProperty("TrackingInformationSerNavigation")]
    public virtual ICollection<DcobjectTrackingInfo> DcobjectTrackingInfo { get; set; } = new List<DcobjectTrackingInfo>();

    [ForeignKey("PatientSer")]
    [InverseProperty("TrackingInformation")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
