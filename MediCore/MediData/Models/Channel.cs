using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", Name = "XIF410Channel")]
public partial class Channel
{
    [Key]
    public long ChannelSer { get; set; }

    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string ChannelId { get; set; } = null!;

    [StringLength(64)]
    public string? ChannelName { get; set; }

    public int? ChannelNumber { get; set; }

    public double? MinLength { get; set; }

    public double? MaxLength { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ChannelSerNavigation")]
    public virtual ICollection<BrachyField> BrachyField { get; set; } = new List<BrachyField>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Channel")]
    public virtual BrachyUnit ResourceSerNavigation { get; set; } = null!;
}
