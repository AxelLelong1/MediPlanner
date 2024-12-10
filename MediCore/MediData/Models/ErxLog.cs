using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ErxEvent", "EventStartDt")]
[Table("erx_log")]
public partial class ErxLog
{
    [Key]
    [Column("erx_event")]
    [StringLength(20)]
    public string ErxEvent { get; set; } = null!;

    [Key]
    [Column("event_start_dt", TypeName = "datetime")]
    public DateTime EventStartDt { get; set; }

    [Column("event_end_dt", TypeName = "datetime")]
    public DateTime? EventEndDt { get; set; }

    [Column("last_updated_ind")]
    [StringLength(1)]
    public string? LastUpdatedInd { get; set; }
}
