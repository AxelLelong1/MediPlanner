using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimChannel
{
    [Column("ctrChannelSer")]
    public long CtrChannelSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

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
}
