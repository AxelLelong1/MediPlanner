using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtVisitTrackingId")]
[Table("pt_visit_tracking")]
public partial class PtVisitTracking
{
    [Key]
    [Column("pt_id")]
    [StringLength(30)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_visit_tracking_id")]
    public int PtVisitTrackingId { get; set; }

    [Column("visit_tracking_typ")]
    public int VisitTrackingTyp { get; set; }

    [Column("visit_tracking_inst_id")]
    [StringLength(30)]
    public string VisitTrackingInstId { get; set; } = null!;

    [Column("tracking_tstamp", TypeName = "datetime")]
    public DateTime TrackingTstamp { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string CurEntryInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [ForeignKey("VisitTrackingInstId, VisitTrackingTyp")]
    [InverseProperty("PtVisitTracking")]
    public virtual VisitTrackingTyp VisitTrackingTypNavigation { get; set; } = null!;
}
