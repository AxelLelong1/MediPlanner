using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtActualId")]
[Table("pt_gnrc_actual")]
public partial class PtGnrcActual
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_actual_id")]
    public int PtActualId { get; set; }

    [Column("completed_qty")]
    public int? CompletedQty { get; set; }

    [Column("charted_tstamp", TypeName = "datetime")]
    public DateTime ChartedTstamp { get; set; }

    [Column("completed_tstamp", TypeName = "datetime")]
    public DateTime? CompletedTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("intv_name")]
    [StringLength(255)]
    public string IntvName { get; set; } = null!;

    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Column("appr_ind")]
    [StringLength(1)]
    public string ApprInd { get; set; } = null!;

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
