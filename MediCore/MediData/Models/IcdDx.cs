using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "IcdCd")]
[Table("icd_dx")]
[Index("IcdCd", Name = "nc1_icd_dx")]
[Index("CacheKeySer", Name = "nc2_icd_dx")]
public partial class IcdDx
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Column("short_title")]
    [StringLength(60)]
    public string ShortTitle { get; set; } = null!;

    [Column("full_title")]
    [StringLength(250)]
    public string FullTitle { get; set; } = null!;

    [Column("cat")]
    [StringLength(1)]
    public string Cat { get; set; } = null!;

    [Column("subdivided")]
    [StringLength(1)]
    public string Subdivided { get; set; } = null!;

    [Column("sex")]
    [StringLength(1)]
    public string? Sex { get; set; }

    [Column("major_dx_cat")]
    [StringLength(2)]
    public string? MajorDxCat { get; set; }

    [Column("age_cd")]
    [StringLength(1)]
    public string? AgeCd { get; set; }

    [Column("list_a_cd")]
    [StringLength(3)]
    public string? ListACd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("active_chg_date", TypeName = "datetime")]
    public DateTime? ActiveChgDate { get; set; }

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

    [Column("include_detail")]
    [StringLength(255)]
    public string? IncludeDetail { get; set; }

    [Column("mnfstn_cd")]
    [StringLength(1)]
    public string? MnfstnCd { get; set; }

    [Column("reltd_mnfstn_desc")]
    [StringLength(50)]
    public string? ReltdMnfstnDesc { get; set; }

    [Column("clinical_desc")]
    [StringLength(250)]
    public string? ClinicalDesc { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("custom_cd_ind")]
    [StringLength(1)]
    public string? CustomCdInd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("cache_key_ser")]
    public long? CacheKeySer { get; set; }

    [Column("reportable_ind")]
    [StringLength(1)]
    public string? ReportableInd { get; set; }

    [Column("mandatory_ind")]
    [StringLength(1)]
    public string? MandatoryInd { get; set; }

    [InverseProperty("IcdDx")]
    public virtual ICollection<OncoPtFsDx> OncoPtFsDx { get; set; } = new List<OncoPtFsDx>();

    [InverseProperty("IcdDx")]
    public virtual ICollection<PtDx> PtDx { get; set; } = new List<PtDx>();

    [InverseProperty("IcdDx")]
    public virtual ICollection<PtExamComp> PtExamComp { get; set; } = new List<PtExamComp>();

    [InverseProperty("IcdDx")]
    public virtual ICollection<XrefIcdGroup> XrefIcdGroup { get; set; } = new List<XrefIcdGroup>();
}
