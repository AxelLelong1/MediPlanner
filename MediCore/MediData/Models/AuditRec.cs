using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("audit_rec")]
public partial class AuditRec
{
    [Key]
    [Column("audit_seq_no")]
    public int AuditSeqNo { get; set; }

    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Column("audit_tstamp", TypeName = "datetime")]
    public DateTime AuditTstamp { get; set; }

    [Column("audit_action_typ")]
    public int AuditActionTyp { get; set; }

    [Column("audit_rec_desc")]
    public string AuditRecDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("app_vers_no")]
    [StringLength(10)]
    public string? AppVersNo { get; set; }

    [Column("app_build_no")]
    [StringLength(10)]
    public string? AppBuildNo { get; set; }

    [ForeignKey("AuditActionTyp")]
    [InverseProperty("AuditRec")]
    public virtual AuditActionTyp AuditActionTypNavigation { get; set; } = null!;
}
