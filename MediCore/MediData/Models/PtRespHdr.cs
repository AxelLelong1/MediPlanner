using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "QstrName", "QstrId")]
[Table("pt_resp_hdr")]
[Index("QstrName", "PtId", "ValidEntryInd", "PtVisitId", "QstrId", "QstrTstamp", "ApprTstamp", Name = "nc1_pt_resp_hdr")]
public partial class PtRespHdr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("qstr_name")]
    [StringLength(20)]
    public string QstrName { get; set; } = null!;

    [Key]
    [Column("qstr_id")]
    public int QstrId { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string ApprFlag { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("hx_ind")]
    [StringLength(1)]
    public string? HxInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("qstr_tstamp", TypeName = "datetime")]
    public DateTime? QstrTstamp { get; set; }

    [Column("author_stkh_id")]
    [StringLength(20)]
    public string? AuthorStkhId { get; set; }

    [Column("pt_entered_ind")]
    [StringLength(1)]
    public string? PtEnteredInd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [InverseProperty("PtRespHdr")]
    public virtual ICollection<PtResp> PtResp { get; set; } = new List<PtResp>();

    [InverseProperty("PtRespHdr")]
    public virtual ICollection<PtTpActionQstr> PtTpActionQstr { get; set; } = new List<PtTpActionQstr>();

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("PtRespHdr")]
    public virtual PtVisit PtVisit { get; set; } = null!;
}
