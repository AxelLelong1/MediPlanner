using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "InstId", "ProviderStdOrderId")]
[Table("provider_std_order")]
[Index("InstId", "Userid", "TpName", "TpVersNo", "PhaseSeqNo", "CycleDay", "EventSeqNo", Name = "nc1_provider_std_order")]
public partial class ProviderStdOrder
{
    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("provider_std_order_id")]
    public int ProviderStdOrderId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("phase_seq_no")]
    public int PhaseSeqNo { get; set; }

    [Column("cycle_day")]
    public int CycleDay { get; set; }

    [Column("event_seq_no")]
    public int EventSeqNo { get; set; }

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("group_desc")]
    [StringLength(50)]
    public string? GroupDesc { get; set; }

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

    [Column("intv_id")]
    public int? IntvId { get; set; }

    [Column("course_no")]
    public int? CourseNo { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
