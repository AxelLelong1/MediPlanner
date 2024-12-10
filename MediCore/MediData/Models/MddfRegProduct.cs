using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Searchkey", "RegionCode", "LanguageId")]
[Table("MDDF_reg_product")]
[Index("RegionCode", "LanguageId", "SPreferredDisplayName", Name = "nc1_MDDF_reg_product")]
[Index("RegionCode", "LanguageId", Name = "nc2_MDDF_reg_product")]
[Index("SnameWithQualifier", Name = "nc3_MDDF_reg_product")]
[Index("ICoreGenericProductId", Name = "nc4_MDDF_reg_product")]
public partial class MddfRegProduct
{
    [Key]
    [Column("region_code")]
    public int RegionCode { get; set; }

    [Key]
    [Column("language_id")]
    public int LanguageId { get; set; }

    [Column("iProductClassId")]
    public int? IProductClassId { get; set; }

    [Column("sPreferredDisplayName")]
    [StringLength(255)]
    public string? SPreferredDisplayName { get; set; }

    [Column("sname_with_qualifier")]
    [StringLength(255)]
    public string? SnameWithQualifier { get; set; }

    [Column("upper_drug_name")]
    [StringLength(255)]
    public string? UpperDrugName { get; set; }

    [Column("iStatusId")]
    public int? IStatusId { get; set; }

    [Key]
    [Column("searchkey")]
    [StringLength(32)]
    public string Searchkey { get; set; } = null!;

    [Column("rtdfgenid")]
    public int? Rtdfgenid { get; set; }

    [Column("rtgenid")]
    public int? Rtgenid { get; set; }

    [Column("gcnseqno")]
    public int? Gcnseqno { get; set; }

    [Column("hicl")]
    public int? Hicl { get; set; }

    [Column("iRoutePrescribedId")]
    public int? IRoutePrescribedId { get; set; }

    [Column("iBaseFormulationId")]
    public int? IBaseFormulationId { get; set; }

    [Column("iStrengthId")]
    public int? IStrengthId { get; set; }

    [Column("iCoreGenericProductId", TypeName = "numeric(12, 0)")]
    public decimal? ICoreGenericProductId { get; set; }

    [Column("iCSM")]
    public int? ICsm { get; set; }

    [Column("iPrescribeById")]
    public int? IPrescribeById { get; set; }

    [Column("dea_class_cd")]
    [StringLength(1)]
    public string? DeaClassCd { get; set; }

    [Column("fdb_gpi")]
    [StringLength(20)]
    public string? FdbGpi { get; set; }
}
