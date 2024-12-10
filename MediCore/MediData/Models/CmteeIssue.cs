using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cmtee_issue")]
public partial class CmteeIssue
{
    [Key]
    [Column("cmtee_issue_typ_id")]
    public int CmteeIssueTypId { get; set; }

    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("cmtee_issue_cat_typ")]
    public int CmteeIssueCatTyp { get; set; }

    [Column("cmtee_issue_topic_typ")]
    public int CmteeIssueTopicTyp { get; set; }

    [Column("cmtee_cat_desc")]
    [StringLength(20)]
    public string CmteeCatDesc { get; set; } = null!;

    [Column("cmtee_topic_desc")]
    [StringLength(30)]
    public string CmteeTopicDesc { get; set; } = null!;

    [Column("cmtee_issue_desc")]
    [StringLength(60)]
    public string CmteeIssueDesc { get; set; } = null!;

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("initial_ind")]
    [StringLength(1)]
    public string? InitialInd { get; set; }

    [Column("monitor_ind")]
    [StringLength(1)]
    public string? MonitorInd { get; set; }

    [Column("ia_ind")]
    [StringLength(1)]
    public string? IaInd { get; set; }

    [Column("cmtee_agenda_id")]
    public int? CmteeAgendaId { get; set; }

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

    [Column("cmtee_issue_abrv")]
    [StringLength(20)]
    public string? CmteeIssueAbrv { get; set; }
}
