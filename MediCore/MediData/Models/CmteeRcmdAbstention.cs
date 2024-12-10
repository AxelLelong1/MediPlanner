using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeIssueId", "StkhId")]
[Table("cmtee_rcmd_abstention")]
public partial class CmteeRcmdAbstention
{
    [Key]
    [Column("cmtee_issue_id")]
    public int CmteeIssueId { get; set; }

    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

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
}
