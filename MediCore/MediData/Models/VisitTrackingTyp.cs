using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "VisitTrackingTyp1")]
[Table("visit_tracking_typ")]
public partial class VisitTrackingTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("visit_tracking_typ")]
    public int VisitTrackingTyp1 { get; set; }

    [Column("visit_tracking_desc")]
    [StringLength(30)]
    public string VisitTrackingDesc { get; set; } = null!;

    [Column("visit_tracking_abrv")]
    [StringLength(2)]
    public string VisitTrackingAbrv { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

    [Column("visit_tracking_seq")]
    public int VisitTrackingSeq { get; set; }

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

    [InverseProperty("VisitTrackingTypNavigation")]
    public virtual ICollection<PtVisitTracking> PtVisitTracking { get; set; } = new List<PtVisitTracking>();
}
