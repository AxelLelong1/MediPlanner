using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class TickerMessage
{
    [Key]
    public long TickerMessageSer { get; set; }

    [StringLength(254)]
    public string FromMachine { get; set; } = null!;

    [StringLength(254)]
    public string MessageType { get; set; } = null!;

    [Column("MsgUID")]
    [StringLength(254)]
    public string MsgUid { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpirationTime { get; set; }

    public string Message { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("TickerMessageSerNavigation")]
    public virtual ICollection<TickerMessageChannel> TickerMessageChannel { get; set; } = new List<TickerMessageChannel>();
}
