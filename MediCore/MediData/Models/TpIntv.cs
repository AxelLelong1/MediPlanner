using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "IntvId")]
[Table("tp_intv")]
public partial class TpIntv
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
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("intv_cat_id")]
    public int IntvCatId { get; set; }

    [Column("intv_name")]
    [StringLength(255)]
    public string IntvName { get; set; } = null!;

    [Column("notification_req")]
    [StringLength(1)]
    public string NotificationReq { get; set; } = null!;

    [Column("notification_days")]
    public int? NotificationDays { get; set; }

    [Column("rqstn_req")]
    [StringLength(1)]
    public string RqstnReq { get; set; } = null!;

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("actual_time_req")]
    [StringLength(1)]
    public string ActualTimeReq { get; set; } = null!;

    [Column("intv_req")]
    [StringLength(1)]
    public string IntvReq { get; set; } = null!;

    [Column("intv_detail_txt")]
    public string? IntvDetailTxt { get; set; }

    [Column("chart_summary_ind")]
    [StringLength(1)]
    public string? ChartSummaryInd { get; set; }

    [Column("instr_ind")]
    [StringLength(1)]
    public string? InstrInd { get; set; }

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

    [Column("phase_avl")]
    public int? PhaseAvl { get; set; }

    [Column("group_ind")]
    [StringLength(1)]
    public string? GroupInd { get; set; }

    [Column("sch_ind")]
    [StringLength(1)]
    public string? SchInd { get; set; }

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("rule_ind")]
    [StringLength(1)]
    public string? RuleInd { get; set; }

    [Column("this_visit_req_ind")]
    [StringLength(1)]
    public string? ThisVisitReqInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("dose_calc_ind")]
    [StringLength(1)]
    public string? DoseCalcInd { get; set; }

    [Column("lib_intv_id")]
    public int? LibIntvId { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [InverseProperty("TpIntv")]
    public virtual ICollection<CycleEvent> CycleEvent { get; set; } = new List<CycleEvent>();

    [ForeignKey("EventTyp")]
    [InverseProperty("TpIntv")]
    public virtual EventTyp EventTypNavigation { get; set; } = null!;

    [InverseProperty("TpIntv")]
    public virtual TpAgt? TpAgt { get; set; }

    [InverseProperty("TpIntv")]
    public virtual TpAsmt? TpAsmt { get; set; }

    [InverseProperty("TpIntv")]
    public virtual TpIvTherapy? TpIvTherapy { get; set; }

    [InverseProperty("TpIntv")]
    public virtual TpQstr? TpQstr { get; set; }

    [InverseProperty("TpIntv")]
    public virtual ICollection<TpSchGroup> TpSchGroupTpIntv { get; set; } = new List<TpSchGroup>();

    [InverseProperty("TpIntvNavigation")]
    public virtual ICollection<TpSchGroup> TpSchGroupTpIntvNavigation { get; set; } = new List<TpSchGroup>();

    [ForeignKey("TpName, TpVersNo")]
    [InverseProperty("TpIntv")]
    public virtual TxPln TxPln { get; set; } = null!;

    [InverseProperty("TpIntv")]
    public virtual XrefTpTest? XrefTpTest { get; set; }

    [InverseProperty("TpIntv")]
    public virtual XrefTrTypPln? XrefTrTypPln { get; set; }
}
