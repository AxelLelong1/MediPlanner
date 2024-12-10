using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee")]
public partial class Cmtee
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("cmtee_name")]
    [StringLength(125)]
    public string CmteeName { get; set; } = null!;

    [Column("cmtee_desc")]
    [StringLength(255)]
    public string CmteeDesc { get; set; } = null!;

    [Column("cmtee_abbr")]
    [StringLength(8)]
    public string? CmteeAbbr { get; set; }

    [Column("internal_ind")]
    [StringLength(1)]
    public string InternalInd { get; set; } = null!;

    [Column("lead_time")]
    public int? LeadTime { get; set; }

    [Column("default_room")]
    [StringLength(30)]
    public string? DefaultRoom { get; set; }

    [Column("email_group_name")]
    [StringLength(50)]
    public string? EmailGroupName { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [Column("ltr_resp_warn_days")]
    public int? LtrRespWarnDays { get; set; }

    [Column("ltr_resp_final_days")]
    public int? LtrRespFinalDays { get; set; }

    [Column("courtesy_pct")]
    public int? CourtesyPct { get; set; }
}
