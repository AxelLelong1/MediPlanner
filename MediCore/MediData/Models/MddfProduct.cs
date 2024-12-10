using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MDDF_product")]
public partial class MddfProduct
{
    [Key]
    [Column("iProductId")]
    public int IProductId { get; set; }

    [Column("iChangeTypeId")]
    public int? IChangeTypeId { get; set; }

    [Column("dDateOfChange", TypeName = "datetime")]
    public DateTime? DDateOfChange { get; set; }

    [Column("iCoreGenericProductId")]
    public int? ICoreGenericProductId { get; set; }

    [Column("sPreferredDisplayName")]
    [StringLength(255)]
    public string? SPreferredDisplayName { get; set; }

    [Column("sName")]
    [StringLength(30)]
    public string? SName { get; set; }

    [Column("iQualifierId")]
    public int? IQualifierId { get; set; }

    [Column("iFormulationId")]
    public int? IFormulationId { get; set; }

    [Column("iStrengthId")]
    public int? IStrengthId { get; set; }

    [Column("sOrderNo")]
    [StringLength(15)]
    public string? SOrderNo { get; set; }

    [Column("iLegalId")]
    public int? ILegalId { get; set; }

    [Column("iCompanyId")]
    public int? ICompanyId { get; set; }

    [Column("iStatusId")]
    public int? IStatusId { get; set; }

    [Column("iCSM")]
    public int? ICsm { get; set; }

    [Column("iPrescribeById")]
    public int? IPrescribeById { get; set; }

    [Column("iSugarFree")]
    public int? ISugarFree { get; set; }

    [Column("iProductTypeID")]
    public int? IProductTypeId { get; set; }

    [Column("iProductClassId")]
    public int? IProductClassId { get; set; }

    [Column("iEWApplianceTarrifHierID")]
    public int? IEwapplianceTarrifHierId { get; set; }

    [Column("iScotApplianceTarrifHierID")]
    public int? IScotApplianceTarrifHierId { get; set; }

    [Column("iParallelImport")]
    public int? IParallelImport { get; set; }

    [Column("dProdAddDate", TypeName = "datetime")]
    public DateTime? DProdAddDate { get; set; }

    [Column("dProdDiscDate", TypeName = "datetime")]
    public DateTime? DProdDiscDate { get; set; }

    [Column("iBaseFormulationID")]
    public int? IBaseFormulationId { get; set; }

    [Column("iClinicalSetId")]
    public int? IClinicalSetId { get; set; }

    [Column("iPersonalAdminID")]
    public int? IPersonalAdminId { get; set; }

    [Column("upper_drug_name")]
    [StringLength(106)]
    public string? UpperDrugName { get; set; }

    [Column("sname_with_qualifier")]
    [StringLength(106)]
    public string? SnameWithQualifier { get; set; }

    [Column("iHighRisk")]
    public int? IHighRisk { get; set; }

    [Column("iPickListOrderKey")]
    public int? IPickListOrderKey { get; set; }
}
