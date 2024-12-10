using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ct_issue_rcmd_typ")]
public partial class CtIssueRcmdTyp
{
    [Key]
    [Column("ct_issue_rcmd_typ")]
    public int CtIssueRcmdTyp1 { get; set; }

    [Column("ct_issue_rcmd_desc")]
    [StringLength(20)]
    public string CtIssueRcmdDesc { get; set; } = null!;

    [Column("ct_status_typ")]
    public int CtStatusTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
