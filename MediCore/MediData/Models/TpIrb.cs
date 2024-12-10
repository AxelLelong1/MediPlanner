using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "IrbNum")]
[Table("tp_irb")]
public partial class TpIrb
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("irb_num")]
    public int IrbNum { get; set; }

    [Column("cmtee_date_id")]
    public int? CmteeDateId { get; set; }

    [Column("submit_date", TypeName = "datetime")]
    public DateTime? SubmitDate { get; set; }

    [Column("tp_site_id")]
    public int? TpSiteId { get; set; }

    [Column("cmtee_id")]
    public int? CmteeId { get; set; }

    [Column("agenda_action_typ")]
    public int? AgendaActionTyp { get; set; }

    [Column("revision_num")]
    public int? RevisionNum { get; set; }

    [Column("issue_typ")]
    public int? IssueTyp { get; set; }

    [Column("next_cr_due_date", TypeName = "datetime")]
    public DateTime? NextCrDueDate { get; set; }

    [Column("next_pmc_review_date", TypeName = "datetime")]
    public DateTime? NextPmcReviewDate { get; set; }

    [Column("next_pmc_audit_date", TypeName = "datetime")]
    public DateTime? NextPmcAuditDate { get; set; }

    [Column("require_audit_ind")]
    [StringLength(1)]
    public string? RequireAuditInd { get; set; }

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
