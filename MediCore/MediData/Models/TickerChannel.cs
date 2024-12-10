using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class TickerChannel
{
    [Key]
    public long TickerChannelSer { get; set; }

    [StringLength(254)]
    public string ChannelName { get; set; } = null!;

    [Column("ChannelUID")]
    [StringLength(254)]
    public string ChannelUid { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("TickerChannelSerNavigation")]
    public virtual ICollection<TickerMessageChannel> TickerMessageChannel { get; set; } = new List<TickerMessageChannel>();
}
