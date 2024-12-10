using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("cls_scheme")]
public partial class ClsScheme
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("scheme_author")]
    public int SchemeAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("scheme_name")]
    [StringLength(64)]
    public string SchemeName { get; set; } = null!;

    [Column("scheme_typ")]
    public int SchemeTyp { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("orig_author")]
    public int? OrigAuthor { get; set; }

    [Column("orig_eff_date", TypeName = "datetime")]
    public DateTime? OrigEffDate { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("enm_ind")]
    [StringLength(1)]
    public string? EnmInd { get; set; }

    [Column("cls_scheme_oid")]
    [StringLength(255)]
    public string? ClsSchemeOid { get; set; }

    [InverseProperty("ClsScheme")]
    public virtual ICollection<BmiTrend> BmiTrend { get; set; } = new List<BmiTrend>();

    [InverseProperty("ClsScheme")]
    public virtual ICollection<InstDxCode> InstDxCode { get; set; } = new List<InstDxCode>();

    [ForeignKey("OrigAuthor")]
    [InverseProperty("ClsSchemeOrigAuthorNavigation")]
    public virtual Spsr? OrigAuthorNavigation { get; set; }

    [InverseProperty("ClsScheme")]
    public virtual ICollection<PtDxCode> PtDxCode { get; set; } = new List<PtDxCode>();

    [InverseProperty("ClsScheme")]
    public virtual ICollection<QmEventCode> QmEventCode { get; set; } = new List<QmEventCode>();

    [ForeignKey("SchemeAuthor")]
    [InverseProperty("ClsSchemeSchemeAuthorNavigation")]
    public virtual Spsr SchemeAuthorNavigation { get; set; } = null!;

    [ForeignKey("SchemeTyp")]
    [InverseProperty("ClsScheme")]
    public virtual SchemeTyp SchemeTypNavigation { get; set; } = null!;
}
