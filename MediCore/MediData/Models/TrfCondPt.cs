using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "PtId")]
[Table("trf_cond_pt")]
public partial class TrfCondPt
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("cond_rule")]
    [StringLength(30)]
    public string CondRule { get; set; } = null!;

    [Column("last_trf_tstamp", TypeName = "datetime")]
    public DateTime? LastTrfTstamp { get; set; }

    [Column("resend_all_data")]
    [StringLength(1)]
    public string? ResendAllData { get; set; }

    [Column("suspend_trf_pt")]
    [StringLength(1)]
    public string? SuspendTrfPt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [ForeignKey("InstId, TrfDirctn, CondRule")]
    [InverseProperty("TrfCondPt")]
    public virtual TrfCondRuleInst TrfCondRuleInst { get; set; } = null!;
}
