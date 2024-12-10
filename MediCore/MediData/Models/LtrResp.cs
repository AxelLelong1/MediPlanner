using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ltr_resp")]
public partial class LtrResp
{
    [Key]
    [Column("ltr_id")]
    public int LtrId { get; set; }

    [Column("warn_date", TypeName = "datetime")]
    public DateTime? WarnDate { get; set; }

    [Column("final_date", TypeName = "datetime")]
    public DateTime? FinalDate { get; set; }

    [Column("resp_rcvd_ind")]
    [StringLength(1)]
    public string? RespRcvdInd { get; set; }

    [Column("warn_ltr_id")]
    public int? WarnLtrId { get; set; }

    [Column("final_ltr_id")]
    public int? FinalLtrId { get; set; }

    [Column("dcmnt_id")]
    public int? DcmntId { get; set; }

    [Column("submit_cmtee_issue_id")]
    public int? SubmitCmteeIssueId { get; set; }

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

    [Column("resp_desc")]
    public string? RespDesc { get; set; }
}
