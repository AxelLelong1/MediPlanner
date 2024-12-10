using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtEvalId")]
[Table("pt_tp_eval")]
public partial class PtTpEval
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_eval_id")]
    public int PtEvalId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Column("outcome_id")]
    public int OutcomeId { get; set; }

    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Column("tperiod_id")]
    public int TperiodId { get; set; }

    [Column("offset_hhmm")]
    [StringLength(4)]
    public string? OffsetHhmm { get; set; }

    [Column("offset_desc")]
    [StringLength(40)]
    public string? OffsetDesc { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("individualized_ind")]
    [StringLength(1)]
    public string IndividualizedInd { get; set; } = null!;

    [Column("eval_ind")]
    [StringLength(1)]
    public string EvalInd { get; set; } = null!;

    [Column("achieved_level")]
    public int? AchievedLevel { get; set; }

    [Column("charted_tstamp", TypeName = "datetime")]
    public DateTime? ChartedTstamp { get; set; }

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

    [Column("applicable_ind")]
    [StringLength(1)]
    public string? ApplicableInd { get; set; }

    [Column("event_status")]
    public int? EventStatus { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("PtId, TpName, DateTpInit, OutcomeId")]
    [InverseProperty("PtTpEval")]
    public virtual PtTpOutcome PtTpOutcome { get; set; } = null!;

    [InverseProperty("PtTpEval")]
    public virtual ICollection<VisitNote> VisitNote { get; set; } = new List<VisitNote>();
}
