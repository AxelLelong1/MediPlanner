using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "IcdCd", "CultureCd")]
[Table("icd_dx_culture")]
[Index("CultureCd", "IcdCd", Name = "nc1_icd_dx_culture")]
public partial class IcdDxCulture
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("short_title")]
    [StringLength(60)]
    public string ShortTitle { get; set; } = null!;

    [Column("full_title")]
    [StringLength(250)]
    public string FullTitle { get; set; } = null!;

    [Column("include_detail")]
    [StringLength(255)]
    public string? IncludeDetail { get; set; }

    [Column("clinical_desc")]
    [StringLength(250)]
    public string? ClinicalDesc { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }
}
