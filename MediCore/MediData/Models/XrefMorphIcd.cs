using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MorphClsSchemeId", "MorphCd", "BehaviorCd", "IcdoSiteCd", "SexCd", "IcdClsSchemeId")]
[Table("xref_morph_icd")]
public partial class XrefMorphIcd
{
    [Key]
    [Column("morph_cls_scheme_id")]
    public int MorphClsSchemeId { get; set; }

    [Key]
    [Column("morph_cd")]
    [StringLength(4)]
    public string MorphCd { get; set; } = null!;

    [Key]
    [Column("behavior_cd")]
    [StringLength(1)]
    public string BehaviorCd { get; set; } = null!;

    [Key]
    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string IcdoSiteCd { get; set; } = null!;

    [Key]
    [Column("sex_cd")]
    [StringLength(1)]
    public string SexCd { get; set; } = null!;

    [Key]
    [Column("icd_cls_scheme_id")]
    public int IcdClsSchemeId { get; set; }

    [Column("icd_cd")]
    [StringLength(16)]
    public string IcdCd { get; set; } = null!;

    [Column("conv_grp")]
    public int? ConvGrp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
