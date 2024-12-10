using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "RuleId", "RuleIdDesc")]
[Table("rule_body")]
public partial class RuleBody
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("rule_id")]
    public int RuleId { get; set; }

    [Key]
    [Column("rule_id_desc")]
    [StringLength(40)]
    public string RuleIdDesc { get; set; } = null!;

    [Column("appr")]
    [StringLength(1)]
    public string Appr { get; set; } = null!;

    [Column("orig_rule_id")]
    public int? OrigRuleId { get; set; }

    [Column("orig_inst_id")]
    [StringLength(30)]
    public string? OrigInstId { get; set; }

    [Column("rule_expl")]
    [StringLength(255)]
    public string? RuleExpl { get; set; }

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("RuleBody")]
    public virtual ICollection<RuleComp> RuleComp { get; set; } = new List<RuleComp>();

    [InverseProperty("RuleBody")]
    public virtual ICollection<XrefTpRule> XrefTpRule { get; set; } = new List<XrefTpRule>();
}
