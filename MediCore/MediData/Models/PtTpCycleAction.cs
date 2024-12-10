using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtEventId")]
[Table("pt_tp_cycle_action")]
[Index("PtId", "DateTpInit", "IntvId", Name = "nc1_pt_tp_cycle_action")]
[Index("PtId", "DateTpInit", "OrderId", Name = "nc2_pt_tp_cycle_action")]
[Index("PtId", "PtVrtnSourceId", Name = "nc3_pt_tp_cycle_action")]
[Index("PtId", "DateTpInit", "PhaseSeqNo", "CycleNo", "CycleDay", "RepeatNo", Name = "nc4_pt_tp_cycle_action")]
public partial class PtTpCycleAction
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_event_id")]
    public int PtEventId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("cycle_no")]
    public int CycleNo { get; set; }

    [Column("cycle_day")]
    public int CycleDay { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("repeat_no")]
    public int? RepeatNo { get; set; }

    [Column("intv_id")]
    public int? IntvId { get; set; }

    [Column("event_status")]
    public int? EventStatus { get; set; }

    [Column("charted_tstamp", TypeName = "datetime")]
    public DateTime? ChartedTstamp { get; set; }

    [Column("completed_tstamp", TypeName = "datetime")]
    public DateTime? CompletedTstamp { get; set; }

    [Column("notified_ind")]
    [StringLength(1)]
    public string? NotifiedInd { get; set; }

    [Column("rqstn_ind")]
    [StringLength(1)]
    public string? RqstnInd { get; set; }

    [Column("note_ind")]
    [StringLength(1)]
    public string? NoteInd { get; set; }

    [Column("above_norm_ind")]
    [StringLength(1)]
    public string? AboveNormInd { get; set; }

    [Column("below_norm_ind")]
    [StringLength(1)]
    public string? BelowNormInd { get; set; }

    [Column("completed_qty")]
    public int? CompletedQty { get; set; }

    [Column("notified_tstamp", TypeName = "datetime")]
    public DateTime? NotifiedTstamp { get; set; }

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("sch_tstamp", TypeName = "datetime")]
    public DateTime? SchTstamp { get; set; }

    [Column("charted_shift_id")]
    public int? ChartedShiftId { get; set; }

    [Column("pt_vrtn_source_id")]
    public int? PtVrtnSourceId { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("abnormal_ind")]
    [StringLength(1)]
    public string? AbnormalInd { get; set; }

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

    [Column("pt_cldr_id")]
    public int? PtCldrId { get; set; }

    [Column("cldr_ind")]
    [StringLength(1)]
    public string? CldrInd { get; set; }

    [Column("completed_time_ind")]
    [StringLength(1)]
    public string? CompletedTimeInd { get; set; }

    [InverseProperty("PtTpCycleAction")]
    public virtual ICollection<PtTpActionActual> PtTpActionActual { get; set; } = new List<PtTpActionActual>();

    [InverseProperty("PtTpCycleAction")]
    public virtual ICollection<PtTpActionAgt> PtTpActionAgt { get; set; } = new List<PtTpActionAgt>();

    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpActionAsmt? PtTpActionAsmt { get; set; }

    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpActionIv? PtTpActionIv { get; set; }

    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpActionQstr? PtTpActionQstr { get; set; }

    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpActionTest? PtTpActionTest { get; set; }

    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpActionTr? PtTpActionTr { get; set; }

    [ForeignKey("PtId, DateTpInit, OrderId")]
    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpOrder? PtTpOrder { get; set; }

    [ForeignKey("PtId, DateTpInit, PhaseSeqNo, CycleNo, CycleDay, RepeatNo")]
    [InverseProperty("PtTpCycleAction")]
    public virtual PtTpTperiod? PtTpTperiod { get; set; }
}
