using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtActionId")]
[Table("pt_tp_action_agt")]
[Index("PtId", "PtVisitId", "RxId", "ItemNo", Name = "nc1_pt_tp_action_agt")]
public partial class PtTpActionAgt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_action_id")]
    public int PtActionId { get; set; }

    [Column("pt_event_id")]
    public int PtEventId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("rx_id")]
    public int RxId { get; set; }

    [Column("item_no")]
    public int ItemNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

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

    [Column("admn_id")]
    public int? AdmnId { get; set; }

    [ForeignKey("PtId, PtEventId")]
    [InverseProperty("PtTpActionAgt")]
    public virtual PtTpCycleAction PtTpCycleAction { get; set; } = null!;

    [ForeignKey("PtId, AdmnId")]
    [InverseProperty("PtTpActionAgt")]
    public virtual TherapyItemAdmn? TherapyItemAdmn { get; set; }
}
