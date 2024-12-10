using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("med_name")]
[Index("DrugName", Name = "nc1_med_name")]
[Index("Gpi", Name = "nc2_med_name")]
[Index("UpperDrugName", Name = "nc3_med_name")]
public partial class MedName
{
    [Key]
    [Column("drug_desc_id")]
    [StringLength(6)]
    public string DrugDescId { get; set; } = null!;

    [Column("drug_name")]
    [StringLength(30)]
    public string? DrugName { get; set; }

    [Column("route")]
    [StringLength(2)]
    public string? Route { get; set; }

    [Column("form")]
    [StringLength(4)]
    public string? Form { get; set; }

    [Column("strength")]
    [StringLength(15)]
    public string? Strength { get; set; }

    [Column("unit_of_meas")]
    [StringLength(10)]
    public string? UnitOfMeas { get; set; }

    [Column("bioeq_code")]
    [StringLength(1)]
    public string? BioeqCode { get; set; }

    [Column("ctrl_sbst_code")]
    [StringLength(1)]
    public string? CtrlSbstCode { get; set; }

    [Column("efficacy_code")]
    [StringLength(1)]
    public string? EfficacyCode { get; set; }

    [Column("legend_ind_code")]
    [StringLength(1)]
    public string? LegendIndCode { get; set; }

    [Column("gnrc_code")]
    [StringLength(1)]
    public string? GnrcCode { get; set; }

    [Column("brand_name_code")]
    [StringLength(1)]
    public string? BrandNameCode { get; set; }

    [Column("name_src_code")]
    [StringLength(1)]
    public string? NameSrcCode { get; set; }

    [Column("gpi")]
    [StringLength(14)]
    public string? Gpi { get; set; }

    [Column("kdc")]
    [StringLength(10)]
    public string? Kdc { get; set; }

    [Column("new_ddi")]
    [StringLength(6)]
    public string? NewDdi { get; set; }

    [Column("screenable_flag")]
    [StringLength(1)]
    public string? ScreenableFlag { get; set; }

    [Column("kdc_flag")]
    [StringLength(1)]
    public string? KdcFlag { get; set; }

    [Column("reserve")]
    [StringLength(13)]
    public string? Reserve { get; set; }

    [Column("activity_cd")]
    [StringLength(1)]
    public string? ActivityCd { get; set; }

    [Column("last_chg_dt")]
    [StringLength(8)]
    public string? LastChgDt { get; set; }

    [Column("upper_drug_name")]
    [StringLength(30)]
    public string? UpperDrugName { get; set; }

    [Column("del_flag")]
    [StringLength(1)]
    public string? DelFlag { get; set; }

    [Column("optx_chg_date", TypeName = "datetime")]
    public DateTime? OptxChgDate { get; set; }

    [Column("old_ddi")]
    [StringLength(8)]
    public string? OldDdi { get; set; }
}
