using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo", "OrderId")]
[Table("cycle_event_order")]
public partial class CycleEventOrder
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
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("intv_id")]
    public int IntvId { get; set; }

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

    [Column("prn_repeat_ind")]
    [StringLength(1)]
    public string PrnRepeatInd { get; set; } = null!;

    [Column("cycle_no")]
    public int CycleNo { get; set; }

    [Column("tperiod_id")]
    public int TperiodId { get; set; }

    [Column("offset_hhmm")]
    [StringLength(4)]
    public string? OffsetHhmm { get; set; }

    [Column("offset_desc")]
    [StringLength(255)]
    public string? OffsetDesc { get; set; }

    [Column("cyclical_ind")]
    [StringLength(1)]
    public string CyclicalInd { get; set; } = null!;

    [Column("baseline_dose", TypeName = "decimal(11, 4)")]
    public decimal? BaselineDose { get; set; }

    [Column("agt_intv_status_id")]
    public int? AgtIntvStatusId { get; set; }

    [Column("dow_frq_unit")]
    public int? DowFrqUnit { get; set; }

    [Column("week_frq_unit")]
    public int? WeekFrqUnit { get; set; }

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

    [Column("cldr_ind")]
    [StringLength(1)]
    public string? CldrInd { get; set; }

    [Column("dispense_qty")]
    public int? DispenseQty { get; set; }

    [Column("dispense_vol", TypeName = "numeric(11, 4)")]
    public decimal? DispenseVol { get; set; }

    [Column("dispense_unit")]
    public int? DispenseUnit { get; set; }

    [Column("admn_frq_upper_x")]
    public int? AdmnFrqUpperX { get; set; }
}
