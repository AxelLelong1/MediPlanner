using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtActualLinkId")]
[Table("pt_actual_link")]
[Index("PtId", "FromPtVisitId", "FromPtActualId", "FromEventTyp", Name = "nc1_pt_actual_link")]
[Index("PtId", "ToPtVisitId", "ToPtActualId", "ToEventTyp", Name = "nc2_pt_actual_link")]
public partial class PtActualLink
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_actual_link_id")]
    public int PtActualLinkId { get; set; }

    [Column("from_pt_visit_id")]
    public int FromPtVisitId { get; set; }

    [Column("from_pt_actual_id")]
    public int FromPtActualId { get; set; }

    [Column("from_event_typ")]
    [StringLength(1)]
    public string FromEventTyp { get; set; } = null!;

    [Column("to_pt_visit_id")]
    public int ToPtVisitId { get; set; }

    [Column("to_pt_actual_id")]
    public int ToPtActualId { get; set; }

    [Column("to_event_typ")]
    [StringLength(1)]
    public string ToEventTyp { get; set; } = null!;

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

    [ForeignKey("FromEventTyp")]
    [InverseProperty("PtActualLinkFromEventTypNavigation")]
    public virtual EventTyp FromEventTypNavigation { get; set; } = null!;

    [ForeignKey("ToEventTyp")]
    [InverseProperty("PtActualLinkToEventTypNavigation")]
    public virtual EventTyp ToEventTypNavigation { get; set; } = null!;
}
