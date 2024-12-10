using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo", "CycleDay", "EventSeqNo", "TpName2", "TpVersNo2")]
[Table("linked_event")]
public partial class LinkedEvent
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
    [Column("cycle_day")]
    public int CycleDay { get; set; }

    [Key]
    [Column("event_seq_no")]
    public int EventSeqNo { get; set; }

    [Key]
    [Column("tp_name2")]
    [StringLength(20)]
    public string TpName2 { get; set; } = null!;

    [Key]
    [Column("tp_vers_no2")]
    [StringLength(10)]
    public string TpVersNo2 { get; set; } = null!;

    [Column("phase_seq_no2")]
    public int PhaseSeqNo2 { get; set; }

    [Column("cycle_day2")]
    public int CycleDay2 { get; set; }

    [Column("event_seq_no2")]
    public int EventSeqNo2 { get; set; }

    [Column("linked_event_typ")]
    [StringLength(1)]
    public string LinkedEventTyp { get; set; } = null!;

    [Column("interval_time")]
    public int? IntervalTime { get; set; }

    [Column("interval_units")]
    public int? IntervalUnits { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [ForeignKey("TpName, TpVersNo, PhaseSeqNo, CycleDay, EventSeqNo")]
    [InverseProperty("LinkedEventCycleEvent")]
    public virtual CycleEvent CycleEvent { get; set; } = null!;

    [ForeignKey("TpName2, TpVersNo2, PhaseSeqNo2, CycleDay2, EventSeqNo2")]
    [InverseProperty("LinkedEventCycleEventNavigation")]
    public virtual CycleEvent CycleEventNavigation { get; set; } = null!;
}
