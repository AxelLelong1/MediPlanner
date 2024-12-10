using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DBHistory")]
public partial class Dbhistory
{
    [Key]
    [Column("DBHistorySer")]
    public long DbhistorySer { get; set; }

    [StringLength(32)]
    public string EventType { get; set; } = null!;

    [StringLength(32)]
    public string? StartingRelease { get; set; }

    [StringLength(32)]
    public string? EndingRelease { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(32)]
    public string? UpgrVersion { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }
}
