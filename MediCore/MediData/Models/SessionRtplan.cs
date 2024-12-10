using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("SessionRTPlan")]
[Index("SessionSer", "SessionRtplanSer", Name = "XAK1SessionPlan", IsUnique = true)]
[Index("Status", "SessionSer", Name = "XIE1SessionRTPlan")]
[Index("RtplanSer", Name = "XIF3SessionRTPlan")]
public partial class SessionRtplan
{
    [Key]
    [Column("SessionRTPlanSer")]
    public long SessionRtplanSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long SessionSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(16)]
    public string Status { get; set; } = null!;

    [ForeignKey("RtplanSer")]
    [InverseProperty("SessionRtplan")]
    public virtual Rtplan RtplanSerNavigation { get; set; } = null!;

    [ForeignKey("SessionSer")]
    [InverseProperty("SessionRtplan")]
    public virtual Session SessionSerNavigation { get; set; } = null!;
}
