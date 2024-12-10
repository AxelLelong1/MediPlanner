using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("inst_lab")]
public partial class InstLab
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("next_seq")]
    [StringLength(15)]
    public string? NextSeq { get; set; }

    [Column("start_val")]
    [StringLength(15)]
    public string? StartVal { get; set; }

    [Column("end_val")]
    [StringLength(15)]
    public string? EndVal { get; set; }

    [Column("days_prior")]
    public int? DaysPrior { get; set; }

    [Column("days_after")]
    public int? DaysAfter { get; set; }

    [Column("reset_intrvl")]
    [StringLength(1)]
    public string? ResetIntrvl { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("increment")]
    public int Increment { get; set; }

    [Column("prefix_list")]
    [StringLength(80)]
    public string? PrefixList { get; set; }

    [Column("cur_prefix")]
    [StringLength(10)]
    public string? CurPrefix { get; set; }

    [Column("reset_date", TypeName = "datetime")]
    public DateTime? ResetDate { get; set; }

    [Column("asc_active_ind")]
    [StringLength(1)]
    public string? AscActiveInd { get; set; }

    [Column("prcs_mode_ind")]
    [StringLength(1)]
    public string? PrcsModeInd { get; set; }

    [Column("dsp_pt_key_cd")]
    public int? DspPtKeyCd { get; set; }

    [Column("dsp_pt_key_inst_id")]
    [StringLength(30)]
    public string? DspPtKeyInstId { get; set; }

    [Column("prmy_lab_inst_id")]
    [StringLength(30)]
    public string? PrmyLabInstId { get; set; }

    [Column("prmy_lab_fac_id")]
    public int? PrmyLabFacId { get; set; }

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

    [Column("matched_purge")]
    public int? MatchedPurge { get; set; }

    [Column("unmatched_purge")]
    public int? UnmatchedPurge { get; set; }

    [Column("dflt_visit_typ_parm")]
    [StringLength(1)]
    public string? DfltVisitTypParm { get; set; }

    [Column("dflt_sort_order_parm")]
    [StringLength(1)]
    public string? DfltSortOrderParm { get; set; }

    [Column("dflt_show_tests_parm")]
    [StringLength(1)]
    public string? DfltShowTestsParm { get; set; }

    [Column("dflt_prmy_fac_parm")]
    [StringLength(1)]
    public string? DfltPrmyFacParm { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("InstLab")]
    public virtual Inst Inst { get; set; } = null!;
}
