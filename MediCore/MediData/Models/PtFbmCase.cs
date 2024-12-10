using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtFbmCaseId")]
[Table("pt_fbm_case")]
public partial class PtFbmCase
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_fbm_case_id")]
    public int PtFbmCaseId { get; set; }

    [Column("fbm_pgm_id")]
    public int FbmPgmId { get; set; }

    [Column("pt_dx_id")]
    public int? PtDxId { get; set; }

    [Column("start_tstamp", TypeName = "datetime")]
    public DateTime? StartTstamp { get; set; }

    [Column("stop_tstamp", TypeName = "datetime")]
    public DateTime? StopTstamp { get; set; }

    [Column("fbm_inst_id")]
    [StringLength(30)]
    public string? FbmInstId { get; set; }

    [Column("rcpt_cd")]
    [StringLength(1)]
    public string RcptCd { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("provider_stkh_id")]
    [StringLength(20)]
    public string? ProviderStkhId { get; set; }

    [Column("org_stkh_id")]
    [StringLength(20)]
    public string? OrgStkhId { get; set; }

    [Column("pt_contact_id")]
    public int? PtContactId { get; set; }

    [Column("fbm_pt_fu_typ")]
    public int? FbmPtFuTyp { get; set; }

    [Column("fbm_pt_handling_typ")]
    public int? FbmPtHandlingTyp { get; set; }

    [Column("pt_fbm_case_cmt")]
    public string? PtFbmCaseCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
