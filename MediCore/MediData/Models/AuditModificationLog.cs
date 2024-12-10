using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("audit_modification_log")]
public partial class AuditModificationLog
{
    [Key]
    [Column("audit_modification_log_id")]
    public int AuditModificationLogId { get; set; }

    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("recorded_trans_log_tstamp", TypeName = "datetime")]
    public DateTime? RecordedTransLogTstamp { get; set; }

    [Column("audit_modification_details")]
    [Unicode(false)]
    public string? AuditModificationDetails { get; set; }

    [Column("detected_tstamp", TypeName = "datetime")]
    public DateTime? DetectedTstamp { get; set; }

    [Column("chk_sum_expected")]
    [MaxLength(200)]
    public byte[]? ChkSumExpected { get; set; }

    [Column("chk_sum_actual")]
    [MaxLength(200)]
    public byte[]? ChkSumActual { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
