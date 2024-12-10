using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TickerMessageSer", Name = "XIF722TickerMessageChannel")]
[Index("TickerChannelSer", Name = "XIF723TickerMessageChannel")]
public partial class TickerMessageChannel
{
    [Key]
    public long TickerMessageChannelSer { get; set; }

    public long TickerMessageSer { get; set; }

    public long TickerChannelSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("TickerChannelSer")]
    [InverseProperty("TickerMessageChannel")]
    public virtual TickerChannel TickerChannelSerNavigation { get; set; } = null!;

    [ForeignKey("TickerMessageSer")]
    [InverseProperty("TickerMessageChannel")]
    public virtual TickerMessage TickerMessageSerNavigation { get; set; } = null!;
}
