using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn", "CondRule")]
[Table("trf_cond_rule_inst")]
public partial class TrfCondRuleInst
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
    [Column("cond_rule")]
    [StringLength(30)]
    public string CondRule { get; set; } = null!;

    [Column("process_rule_ind")]
    [StringLength(1)]
    public string ProcessRuleInd { get; set; } = null!;

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

    [ForeignKey("CondRule")]
    [InverseProperty("TrfCondRuleInst")]
    public virtual TrfCondRule CondRuleNavigation { get; set; } = null!;

    [InverseProperty("TrfCondRuleInst")]
    public virtual ICollection<TrfCondPt> TrfCondPt { get; set; } = new List<TrfCondPt>();

    [InverseProperty("TrfCondRuleInst")]
    public virtual ICollection<TrfCondQstr> TrfCondQstr { get; set; } = new List<TrfCondQstr>();

    [InverseProperty("TrfCondRuleInst")]
    public virtual ICollection<TrfCondTp> TrfCondTp { get; set; } = new List<TrfCondTp>();

    [ForeignKey("InstId, TrfDirctn")]
    [InverseProperty("TrfCondRuleInst")]
    public virtual TrfInst TrfInst { get; set; } = null!;
}
