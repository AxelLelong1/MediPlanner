using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDbhistory
{
    [Column("DBHistorySer")]
    public long DbhistorySer { get; set; }

    [StringLength(32)]
    public string EventType { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? Release { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? UpgrVersion { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }
}
