using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetLatestApproval
{
    [Column(TypeName = "numeric(7, 0)")]
    public decimal ApprovalSer { get; set; }

    public int ApprovalRevCount { get; set; }

    public long TypeSer { get; set; }

    public long? Type1Ser { get; set; }

    public long? Type2Ser { get; set; }

    public int? TypeRevCount { get; set; }

    public int? Type1RevCount { get; set; }

    public int? Type2RevCount { get; set; }

    [StringLength(30)]
    public string ApprovalType { get; set; } = null!;

    [StringLength(64)]
    public string Status { get; set; } = null!;

    [StringLength(255)]
    public string StatusUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
