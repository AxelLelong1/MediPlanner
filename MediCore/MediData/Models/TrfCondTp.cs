using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "CondRule", "TpName", "TpVersNo")]
[Table("trf_cond_tp")]
public partial class TrfCondTp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("cond_rule")]
    [StringLength(30)]
    public string CondRule { get; set; } = null!;

    [Column("last_trf_tstamp", TypeName = "datetime")]
    public DateTime? LastTrfTstamp { get; set; }

    [Column("resend_all_data")]
    [StringLength(1)]
    public string? ResendAllData { get; set; }

    [Column("suspend_trf_tp")]
    [StringLength(1)]
    public string? SuspendTrfTp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [ForeignKey("InstId, TrfDirctn, CondRule")]
    [InverseProperty("TrfCondTp")]
    public virtual TrfCondRuleInst TrfCondRuleInst { get; set; } = null!;
}
