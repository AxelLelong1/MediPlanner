using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeId", "CmteeIssueId", "TpName", "TpVersNo")]
[Table("cmtee_agenda_trial")]
public partial class CmteeAgendaTrial
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Key]
    [Column("cmtee_issue_id")]
    public int CmteeIssueId { get; set; }

    [Column("cmtee_agenda_id")]
    public int? CmteeAgendaId { get; set; }

    [Column("cmtee_trial_id")]
    public int? CmteeTrialId { get; set; }

    [Column("irb_num")]
    public int? IrbNum { get; set; }

    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("confirm_ind")]
    [StringLength(1)]
    public string? ConfirmInd { get; set; }

    [Column("distributed_ind")]
    [StringLength(1)]
    public string? DistributedInd { get; set; }

    [Column("rcmd_points")]
    [StringLength(255)]
    public string? RcmdPoints { get; set; }

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
