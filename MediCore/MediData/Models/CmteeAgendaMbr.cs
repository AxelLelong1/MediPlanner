using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeId", "CmteeIssueId", "CmteeAgendaId", "CmteeMbrStkhId")]
[Table("cmtee_agenda_mbr")]
public partial class CmteeAgendaMbr
{
    [Key]
    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Key]
    [Column("cmtee_issue_id")]
    public int CmteeIssueId { get; set; }

    [Key]
    [Column("cmtee_agenda_id")]
    public int CmteeAgendaId { get; set; }

    [Key]
    [Column("cmtee_mbr_stkh_id")]
    [StringLength(20)]
    public string CmteeMbrStkhId { get; set; } = null!;

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("excd_ind")]
    [StringLength(1)]
    public string? ExcdInd { get; set; }

    [Column("primary_ind")]
    [StringLength(1)]
    public string? PrimaryInd { get; set; }

    [Column("secondary_ind")]
    [StringLength(1)]
    public string? SecondaryInd { get; set; }

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

    [Column("stat_ind")]
    [StringLength(1)]
    public string? StatInd { get; set; }
}
