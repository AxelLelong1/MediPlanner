using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("trf_scrub_rule")]
public partial class TrfScrubRule
{
    [Key]
    [Column("scrub_rule")]
    [StringLength(30)]
    public string ScrubRule { get; set; } = null!;

    [Column("rule_desc")]
    [StringLength(60)]
    public string? RuleDesc { get; set; }

    [Column("enc_flag")]
    [StringLength(1)]
    public string EncFlag { get; set; } = null!;

    [Column("decd_fnctn")]
    [StringLength(30)]
    public string? DecdFnctn { get; set; }

    [Column("enc_fnctn")]
    [StringLength(30)]
    public string? EncFnctn { get; set; }

    [Column("spec_fnctn")]
    [StringLength(30)]
    public string? SpecFnctn { get; set; }

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

    [InverseProperty("ScrubRuleNavigation")]
    public virtual ICollection<ImpexpColumns> ImpexpColumns { get; set; } = new List<ImpexpColumns>();

    [InverseProperty("ScrubRuleNavigation")]
    public virtual ICollection<TrfEncVal> TrfEncVal { get; set; } = new List<TrfEncVal>();

    [InverseProperty("ScrubRuleNavigation")]
    public virtual ICollection<TrfScrubCondRul> TrfScrubCondRul { get; set; } = new List<TrfScrubCondRul>();
}
