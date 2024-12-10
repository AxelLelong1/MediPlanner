using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo", "InstId", "RuleId", "RuleIdDesc")]
[Table("xref_tp_rule")]
public partial class XrefTpRule
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

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

    [Column("rule_cls")]
    public int RuleCls { get; set; }

    [Column("req")]
    [StringLength(1)]
    public string Req { get; set; } = null!;

    [Column("rule_seq")]
    [StringLength(10)]
    public string RuleSeq { get; set; } = null!;

    [Column("rule_desc")]
    public string? RuleDesc { get; set; }

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

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("bibliog_citation")]
    public string? BibliogCitation { get; set; }

    [Column("intervention_developer")]
    public string? InterventionDeveloper { get; set; }

    [Column("funding_source")]
    public string? FundingSource { get; set; }

    [Column("revision_date_txt")]
    public string? RevisionDateTxt { get; set; }

    [Column("reference_url")]
    public string? ReferenceUrl { get; set; }

    [ForeignKey("TpName, TpVersNo, PhaseSeqNo")]
    [InverseProperty("XrefTpRule")]
    public virtual Phase Phase { get; set; } = null!;

    [ForeignKey("InstId, RuleId, RuleIdDesc")]
    [InverseProperty("XrefTpRule")]
    public virtual RuleBody RuleBody { get; set; } = null!;
}
