using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_ndc")]
[Index("DrugDescId", Name = "nc1_med_ndc")]
[Index("Gppc", "ItemStatusFlag", "IdNoTypeCd", Name = "nc2_med_ndc")]
public partial class MedNdc
{
    [Key]
    [Column("ndc_upc_hri_cd")]
    [StringLength(11)]
    public string NdcUpcHriCd { get; set; } = null!;

    [Column("drug_desc_id")]
    [StringLength(6)]
    public string? DrugDescId { get; set; }

    [Column("tee_cd")]
    [StringLength(2)]
    public string? TeeCd { get; set; }

    [Column("dea_class_cd")]
    [StringLength(1)]
    public string? DeaClassCd { get; set; }

    [Column("desi_cd")]
    [StringLength(1)]
    public string? DesiCd { get; set; }

    [Column("rx_otc_cd")]
    [StringLength(1)]
    public string? RxOtcCd { get; set; }

    [Column("gppc")]
    [StringLength(8)]
    public string? Gppc { get; set; }

    [Column("old_key_cd")]
    [StringLength(11)]
    public string? OldKeyCd { get; set; }

    [Column("new_key_cd")]
    [StringLength(11)]
    public string? NewKeyCd { get; set; }

    [Column("repackage_cd")]
    [StringLength(1)]
    public string? RepackageCd { get; set; }

    [Column("id_no_type_cd")]
    [StringLength(1)]
    public string? IdNoTypeCd { get; set; }

    [Column("thrd_party_rstr_cd")]
    [StringLength(1)]
    public string? ThrdPartyRstrCd { get; set; }

    [Column("kdc")]
    [StringLength(10)]
    public string? Kdc { get; set; }

    [Column("kdc_flag")]
    [StringLength(1)]
    public string? KdcFlag { get; set; }

    [Column("labeler_cd")]
    [StringLength(5)]
    public string? LabelerCd { get; set; }

    [Column("multi_srce_cd")]
    [StringLength(1)]
    public string? MultiSrceCd { get; set; }

    [Column("name_type_cd")]
    [StringLength(1)]
    public string? NameTypeCd { get; set; }

    [Column("reserve")]
    [StringLength(46)]
    public string? Reserve { get; set; }

    [Column("activity_cd")]
    [StringLength(1)]
    public string? ActivityCd { get; set; }

    [Column("last_chg_dt")]
    [StringLength(8)]
    public string? LastChgDt { get; set; }

    [Column("del_flag")]
    [StringLength(1)]
    public string? DelFlag { get; set; }

    [Column("optx_chg_date", TypeName = "datetime")]
    public DateTime? OptxChgDate { get; set; }

    [Column("item_status_flag")]
    [StringLength(1)]
    public string? ItemStatusFlag { get; set; }

    [Column("innerpack_cd")]
    [StringLength(1)]
    public string? InnerpackCd { get; set; }

    [Column("clinic_pack_cd")]
    [StringLength(1)]
    public string? ClinicPackCd { get; set; }

    [Column("reimburse_ind")]
    [StringLength(1)]
    public string? ReimburseInd { get; set; }

    [Column("price_spread_cd")]
    [StringLength(1)]
    public string? PriceSpreadCd { get; set; }
}
