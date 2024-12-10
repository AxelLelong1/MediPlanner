using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TestId", "AlertId")]
[Table("pt_alert")]
[Index("AlertStkhId", Name = "nc1_pt_alert")]
[Index("AlertStkhId", "AlertTstamp", Name = "nc2_pt_alert")]
public partial class PtAlert
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("test_id")]
    public int TestId { get; set; }

    [Key]
    [Column("alert_id")]
    public int AlertId { get; set; }

    [Column("alert_stkh_id")]
    [StringLength(20)]
    public string AlertStkhId { get; set; } = null!;

    [Column("alert_tstamp", TypeName = "datetime")]
    public DateTime AlertTstamp { get; set; }

    [Column("alert_inst_id")]
    [StringLength(30)]
    public string AlertInstId { get; set; } = null!;

    [Column("alert_pending_ind")]
    [StringLength(1)]
    public string AlertPendingInd { get; set; } = null!;

    [Column("clr_reason_cd")]
    [StringLength(1)]
    public string? ClrReasonCd { get; set; }

    [Column("clr_userid")]
    [StringLength(255)]
    public string? ClrUserid { get; set; }

    [Column("clr_tstamp", TypeName = "datetime")]
    public DateTime? ClrTstamp { get; set; }

    [Column("clr_inst_id")]
    [StringLength(30)]
    public string? ClrInstId { get; set; }

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
}
