using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("scheduled_export_log")]
public partial class ScheduledExportLog
{
    [Key]
    [Column("scheduled_export_log_id")]
    public int ScheduledExportLogId { get; set; }

    [Column("scheduled_export_id")]
    public int ScheduledExportId { get; set; }

    [Column("event_code")]
    [StringLength(1)]
    public string EventCode { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("log_message")]
    public string? LogMessage { get; set; }

    [Column("file_location")]
    [StringLength(255)]
    public string? FileLocation { get; set; }

    [Column("secure_hash")]
    [MaxLength(32)]
    public byte[]? SecureHash { get; set; }
}
