using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo", "CycleDay", "EventSeqNo")]
[Table("cycle_event")]
[Index("TpName", "TpVersNo", "IntvId", "PhaseSeqNo", "CycleDay", "EventSeqNo", Name = "nc1_cycle_event")]
public partial class CycleEvent
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

    [Column("tp_cycle_no")]
    public int? TpCycleNo { get; set; }

    [Key]
    [Column("cycle_day")]
    public int CycleDay { get; set; }

    [Key]
    [Column("event_seq_no")]
    public int EventSeqNo { get; set; }

    [Column("intv_id")]
    public int? IntvId { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("cyclical_ind")]
    [StringLength(1)]
    public string? CyclicalInd { get; set; }

    [Column("offset_hhmm")]
    [StringLength(4)]
    public string? OffsetHhmm { get; set; }

    [Column("offset_desc")]
    [StringLength(255)]
    public string? OffsetDesc { get; set; }

    [Column("prn_ind")]
    [StringLength(1)]
    public string? PrnInd { get; set; }

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

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("order_display_no")]
    public int? OrderDisplayNo { get; set; }

    [Column("prn_repeat_ind")]
    [StringLength(1)]
    public string? PrnRepeatInd { get; set; }

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

    [Column("dow_frq_unit")]
    public int? DowFrqUnit { get; set; }

    [Column("week_frq_unit")]
    public int? WeekFrqUnit { get; set; }

    [Column("chart_summary_ind")]
    [StringLength(1)]
    public string ChartSummaryInd { get; set; } = null!;

    [Column("event_desc")]
    [StringLength(255)]
    public string? EventDesc { get; set; }

    [Column("time_suppress_ind")]
    [StringLength(1)]
    public string? TimeSuppressInd { get; set; }

    [Column("renewable_ind")]
    [StringLength(1)]
    public string? RenewableInd { get; set; }

    [Column("chart_req_ind")]
    [StringLength(1)]
    public string? ChartReqInd { get; set; }

    [Column("vrbl_req_ind")]
    [StringLength(1)]
    public string? VrblReqInd { get; set; }

    [Column("med_mntr_asmt_ind")]
    [StringLength(1)]
    public string? MedMntrAsmtInd { get; set; }

    [Column("dispense_qty")]
    public int? DispenseQty { get; set; }

    [Column("no_events")]
    public int? NoEvents { get; set; }

    [Column("dispense_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispenseVol { get; set; }

    [Column("dispense_unit")]
    public int? DispenseUnit { get; set; }

    [Column("admn_frq_upper_x")]
    public int? AdmnFrqUpperX { get; set; }

    [Column("spsr_stkh_id")]
    [StringLength(20)]
    public string? SpsrStkhId { get; set; }

    [Column("prn_reason_typ")]
    public int? PrnReasonTyp { get; set; }

    [InverseProperty("CycleEvent")]
    public virtual ICollection<LinkedEvent> LinkedEventCycleEvent { get; set; } = new List<LinkedEvent>();

    [InverseProperty("CycleEventNavigation")]
    public virtual ICollection<LinkedEvent> LinkedEventCycleEventNavigation { get; set; } = new List<LinkedEvent>();

    [ForeignKey("TpName, TpVersNo, IntvId")]
    [InverseProperty("CycleEvent")]
    public virtual TpIntv? TpIntv { get; set; }

    [ForeignKey("TpName, TpVersNo, PhaseSeqNo, CycleDay")]
    [InverseProperty("CycleEvent")]
    public virtual TpTperiod TpTperiod { get; set; } = null!;
}
