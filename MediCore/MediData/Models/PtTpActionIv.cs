using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtEventId")]
[Table("pt_tp_action_iv")]
[Index("PtId", "PtVisitId", "PtIvTherapyId", Name = "nc1_pt_tp_action_iv")]
public partial class PtTpActionIv
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_event_id")]
    public int PtEventId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("pt_iv_therapy_id")]
    public int PtIvTherapyId { get; set; }

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

    [ForeignKey("PtId, PtVisitId, PtIvTherapyId")]
    [InverseProperty("PtTpActionIv")]
    public virtual PtIvTherapy PtIvTherapy { get; set; } = null!;

    [ForeignKey("PtId, PtEventId")]
    [InverseProperty("PtTpActionIv")]
    public virtual PtTpCycleAction PtTpCycleAction { get; set; } = null!;
}
