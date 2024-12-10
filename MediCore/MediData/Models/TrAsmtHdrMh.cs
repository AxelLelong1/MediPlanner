using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "TrAsmtHdrId", "RevisionNo")]
[Table("tr_asmt_hdr_mh")]
public partial class TrAsmtHdrMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("tr_asmt_hdr_id")]
    public int TrAsmtHdrId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string ApprInd { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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

    [Column("tr_obj_ind")]
    [StringLength(1)]
    public string? TrObjInd { get; set; }

    [Column("tr_asmt_eff_date", TypeName = "datetime")]
    public DateTime? TrAsmtEffDate { get; set; }

    [Column("gs_author")]
    public int? GsAuthor { get; set; }

    [Column("asmt_date", TypeName = "datetime")]
    public DateTime? AsmtDate { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("tr_reason")]
    public string? TrReason { get; set; }

    [Column("review_rqd_ind")]
    [StringLength(1)]
    public string? ReviewRqdInd { get; set; }

    [Column("reviewed_ind")]
    [StringLength(1)]
    public string? ReviewedInd { get; set; }

    [Column("reviewer_stkh_id")]
    [StringLength(20)]
    public string? ReviewerStkhId { get; set; }

    [Column("reviewed_tstamp", TypeName = "datetime")]
    public DateTime? ReviewedTstamp { get; set; }

    [Column("pt_entered_ind")]
    [StringLength(1)]
    public string? PtEnteredInd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }
}
