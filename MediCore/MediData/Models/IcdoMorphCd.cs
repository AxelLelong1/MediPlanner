using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ClsSchemeId", "MorphCd", "BehaviorCd", "MorphCdSeq")]
[Table("icdo_morph_cd")]
[Index("CacheKeySer", Name = "nc1_icdo_morph_cd")]
public partial class IcdoMorphCd
{
    [Key]
    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Key]
    [Column("morph_cd")]
    [StringLength(4)]
    public string MorphCd { get; set; } = null!;

    [Key]
    [Column("behavior_cd")]
    [StringLength(1)]
    public string BehaviorCd { get; set; } = null!;

    [Key]
    [Column("morph_cd_seq")]
    public int MorphCdSeq { get; set; }

    [Column("morph_desc")]
    [StringLength(100)]
    public string? MorphDesc { get; set; }

    [Column("icdo_morph_typ")]
    public int? IcdoMorphTyp { get; set; }

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

    [Column("conv_grp")]
    public int? ConvGrp { get; set; }

    [Column("varis_histology_cd")]
    [StringLength(16)]
    public string VarisHistologyCd { get; set; } = null!;

    [Column("cache_key_ser")]
    public long? CacheKeySer { get; set; }

    [ForeignKey("BehaviorCd")]
    [InverseProperty("IcdoMorphCd")]
    public virtual BehaviorCd BehaviorCdNavigation { get; set; } = null!;

    [ForeignKey("IcdoMorphTyp")]
    [InverseProperty("IcdoMorphCd")]
    public virtual IcdoMorphTyp? IcdoMorphTypNavigation { get; set; }
}
