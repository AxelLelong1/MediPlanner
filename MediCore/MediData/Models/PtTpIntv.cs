using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "IntvId")]
[Table("pt_tp_intv")]
[Index("TpName", Name = "nc1_pt_tp_intv")]
public partial class PtTpIntv
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("phase_avl")]
    public int? PhaseAvl { get; set; }

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

    [Column("chart_summary_ind")]
    [StringLength(1)]
    public string ChartSummaryInd { get; set; } = null!;

    [Column("intv_req")]
    [StringLength(1)]
    public string IntvReq { get; set; } = null!;

    [Column("intv_detail_txt")]
    public string? IntvDetailTxt { get; set; }

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("individualized_ind")]
    [StringLength(1)]
    public string IndividualizedInd { get; set; } = null!;

    [Column("sch_ind")]
    [StringLength(1)]
    public string? SchInd { get; set; }

    [Column("group_ind")]
    [StringLength(1)]
    public string? GroupInd { get; set; }

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

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("lib_intv_id")]
    public int? LibIntvId { get; set; }

    [ForeignKey("EventTyp")]
    [InverseProperty("PtTpIntv")]
    public virtual EventTyp EventTypNavigation { get; set; } = null!;

    [ForeignKey("PtId, DateTpInit")]
    [InverseProperty("PtTpIntv")]
    public virtual PtTp PtTp { get; set; } = null!;

    [InverseProperty("PtTpIntv")]
    public virtual PtTpAgt? PtTpAgt { get; set; }

    [InverseProperty("PtTpIntv")]
    public virtual PtTpAsmt? PtTpAsmt { get; set; }

    [InverseProperty("PtTpIntv")]
    public virtual PtTpIvTherapy? PtTpIvTherapy { get; set; }

    [InverseProperty("PtTpIntv")]
    public virtual PtTpQstr? PtTpQstr { get; set; }

    [InverseProperty("PtTpIntv")]
    public virtual ICollection<PtTpSchGroup> PtTpSchGroupPtTpIntv { get; set; } = new List<PtTpSchGroup>();

    [InverseProperty("PtTpIntvNavigation")]
    public virtual ICollection<PtTpSchGroup> PtTpSchGroupPtTpIntvNavigation { get; set; } = new List<PtTpSchGroup>();

    [InverseProperty("PtTpIntv")]
    public virtual PtTpTest? PtTpTest { get; set; }

    [InverseProperty("PtTpIntv")]
    public virtual PtTpTr? PtTpTr { get; set; }
}
