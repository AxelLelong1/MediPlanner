using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "PhaseSeqNo", "CycleEventId")]
[Table("cycle_event_detail")]
public partial class CycleEventDetail
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
    [Column("cycle_event_id")]
    public int CycleEventId { get; set; }

    [Column("cycle_no")]
    public int CycleNo { get; set; }

    [Column("cycle_day")]
    public int CycleDay { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("notified_ind")]
    [StringLength(1)]
    public string NotifiedInd { get; set; } = null!;

    [Column("rqstn_ind")]
    [StringLength(1)]
    public string RqstnInd { get; set; } = null!;

    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("event_status")]
    public int? EventStatus { get; set; }

    [Column("sch_tstamp", TypeName = "datetime")]
    public DateTime? SchTstamp { get; set; }

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
}
