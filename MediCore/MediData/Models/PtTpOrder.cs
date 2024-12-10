using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit", "OrderId")]
[Table("pt_tp_order")]
public partial class PtTpOrder
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("prn_ind")]
    [StringLength(1)]
    public string PrnInd { get; set; } = null!;

    [Column("admn_frq_cd")]
    public int? AdmnFrqCd { get; set; }

    [Column("admn_frq_x")]
    public int? AdmnFrqX { get; set; }

    [Column("admn_frq_unit")]
    public int? AdmnFrqUnit { get; set; }

    [Column("admn_dur")]
    public int? AdmnDur { get; set; }

    [Column("admn_dur_unit")]
    public int? AdmnDurUnit { get; set; }

    [Column("individualized_ind")]
    [StringLength(1)]
    public string IndividualizedInd { get; set; } = null!;

    [Column("prn_repeat_ind")]
    [StringLength(1)]
    public string? PrnRepeatInd { get; set; }

    [Column("start_vrbl_id")]
    public int? StartVrblId { get; set; }

    [Column("stop_vrbl_id")]
    public int? StopVrblId { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("cycle_no")]
    public int? CycleNo { get; set; }

    [Column("tperiod_id")]
    public int? TperiodId { get; set; }

    [Column("repeat_no")]
    public int? RepeatNo { get; set; }

    [Column("offset_hhmm")]
    [StringLength(4)]
    public string? OffsetHhmm { get; set; }

    [Column("offset_desc")]
    [StringLength(255)]
    public string? OffsetDesc { get; set; }

    [Column("charted_ind")]
    [StringLength(1)]
    public string? ChartedInd { get; set; }

    [Column("cyclical_ind")]
    [StringLength(1)]
    public string? CyclicalInd { get; set; }

    [Column("baseline_dose", TypeName = "numeric(11, 4)")]
    public decimal? BaselineDose { get; set; }

    [Column("pln_dose", TypeName = "numeric(11, 4)")]
    public decimal? PlnDose { get; set; }

    [Column("dow_frq_unit")]
    public int? DowFrqUnit { get; set; }

    [Column("week_frq_unit")]
    public int? WeekFrqUnit { get; set; }

    [Column("course_desc")]
    [StringLength(255)]
    public string? CourseDesc { get; set; }

    [Column("chart_summary_ind")]
    [StringLength(1)]
    public string ChartSummaryInd { get; set; } = null!;

    [Column("time_suppress_ind")]
    [StringLength(1)]
    public string? TimeSuppressInd { get; set; }

    [Column("renewable_ind")]
    [StringLength(1)]
    public string? RenewableInd { get; set; }

    [Column("start_order_tstamp", TypeName = "datetime")]
    public DateTime? StartOrderTstamp { get; set; }

    [Column("end_order_tstamp", TypeName = "datetime")]
    public DateTime? EndOrderTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("chart_req_ind")]
    [StringLength(1)]
    public string? ChartReqInd { get; set; }

    [Column("renew_dur")]
    public int? RenewDur { get; set; }

    [Column("pt_cldr_id")]
    public int? PtCldrId { get; set; }

    [Column("cldr_ind")]
    [StringLength(1)]
    public string? CldrInd { get; set; }

    [Column("med_mntr_asmt_ind")]
    [StringLength(1)]
    public string? MedMntrAsmtInd { get; set; }

    [Column("dispense_qty")]
    public int? DispenseQty { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("dispense_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispenseVol { get; set; }

    [Column("dispense_unit")]
    public int? DispenseUnit { get; set; }

    [Column("admn_frq_upper_x")]
    public int? AdmnFrqUpperX { get; set; }

    [ForeignKey("PtId, DateTpInit")]
    [InverseProperty("PtTpOrder")]
    public virtual PtTp PtTp { get; set; } = null!;

    [InverseProperty("PtTpOrder")]
    public virtual ICollection<PtTpCycleAction> PtTpCycleAction { get; set; } = new List<PtTpCycleAction>();

    [InverseProperty("PtTpOrder")]
    public virtual ICollection<PtTpOrderRenew> PtTpOrderRenew { get; set; } = new List<PtTpOrderRenew>();
}
