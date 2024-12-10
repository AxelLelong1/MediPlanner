using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CnteeIssueId", "CmteeIssueRcmdId")]
[Table("xref_cmtee_issue_rcmd")]
public partial class XrefCmteeIssueRcmd
{
    [Key]
    [Column("cntee_issue_id")]
    public int CnteeIssueId { get; set; }

    [Key]
    [Column("cmtee_issue_rcmd_id")]
    public int CmteeIssueRcmdId { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("ct_topic_typ")]
    public int? CtTopicTyp { get; set; }

    [Column("ltr_template_id")]
    public int? LtrTemplateId { get; set; }

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
