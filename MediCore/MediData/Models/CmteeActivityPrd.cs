using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeId", "ActivityTyp", "ActivityPrd")]
[Table("cmtee_activity_prd")]
public partial class CmteeActivityPrd
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Key]
    [Column("activity_typ")]
    public int ActivityTyp { get; set; }

    [Key]
    [Column("activity_prd")]
    public int ActivityPrd { get; set; }

    [Column("activity_gap_dur")]
    public int? ActivityGapDur { get; set; }

    [Column("activity_gap_unit")]
    public int? ActivityGapUnit { get; set; }

    [Column("alert_days")]
    public int? AlertDays { get; set; }

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

    [Column("mode_ind")]
    [StringLength(1)]
    public string? ModeInd { get; set; }
}
