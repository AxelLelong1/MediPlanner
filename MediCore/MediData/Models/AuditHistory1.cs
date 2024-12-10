using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AuditRecId", "PtId", "AuditTableName", "AuditConcatKey")]
[Table("audit_history_1")]
[Index("AuditConcatKey", Name = "nc1_audit_history_1")]
public partial class AuditHistory1
{
    [Key]
    [Column("audit_rec_id")]
    public int AuditRecId { get; set; }

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("audit_table_name")]
    [StringLength(30)]
    public string AuditTableName { get; set; } = null!;

    [Key]
    [Column("audit_concat_key")]
    [StringLength(255)]
    public string AuditConcatKey { get; set; } = null!;

    [Column("audit_prev_data_value")]
    public string? AuditPrevDataValue { get; set; }

    [Column("audit_row_keys")]
    public string? AuditRowKeys { get; set; }

    [Column("audit_reason_cd")]
    public int? AuditReasonCd { get; set; }

    [Column("audit_reason_txt")]
    public string? AuditReasonTxt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }
}
