using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_agenda_issue")]
public partial class CmteeAgendaIssue
{
    [Key]
    [Column("cmtee_issue_id")]
    public int CmteeIssueId { get; set; }

    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("cmtee_agenda_id")]
    public int CmteeAgendaId { get; set; }

    [Column("agenda_issue_typ")]
    public int AgendaIssueTyp { get; set; }

    [Column("cmtee_issue_rcmd_id")]
    public int? CmteeIssueRcmdId { get; set; }

    [Column("rcmd_points_desc")]
    public string? RcmdPointsDesc { get; set; }

    [Column("motion")]
    [StringLength(255)]
    public string? Motion { get; set; }

    [Column("probation_dur")]
    public int? ProbationDur { get; set; }

    [Column("probation_dur_unit")]
    public int? ProbationDurUnit { get; set; }

    [Column("orig_cmtee_issue_id")]
    public int? OrigCmteeIssueId { get; set; }

    [Column("ltr_id")]
    public int? LtrId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("confirm_ind")]
    [StringLength(1)]
    public string? ConfirmInd { get; set; }

    [Column("distributed_ind")]
    [StringLength(1)]
    public string? DistributedInd { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("cmtee_issue_cmt")]
    public string? CmteeIssueCmt { get; set; }

    [Column("trf_cmtee_id")]
    public int? TrfCmteeId { get; set; }

    [Column("reg_track_id")]
    public int? RegTrackId { get; set; }

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
