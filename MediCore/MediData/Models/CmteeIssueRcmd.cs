using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_issue_rcmd")]
public partial class CmteeIssueRcmd
{
    [Key]
    [Column("cmtee_issue_rcmd_id")]
    public int CmteeIssueRcmdId { get; set; }

    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("cmtee_issue_rcmd_typ")]
    public int CmteeIssueRcmdTyp { get; set; }

    [Column("cmtee_issue_rcmd_desc")]
    [StringLength(40)]
    public string CmteeIssueRcmdDesc { get; set; } = null!;

    [Column("rcmd_motion_desc")]
    [StringLength(255)]
    public string? RcmdMotionDesc { get; set; }

    [Column("cmtee_status_typ")]
    public int? CmteeStatusTyp { get; set; }

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
