using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_drug_seg")]
[Index("ErxSegRefId", Name = "nc1_erx_drug_seg")]
public partial class ErxDrugSeg
{
    [Key]
    [Column("erx_drug_id")]
    public int ErxDrugId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("drug_desc")]
    [StringLength(110)]
    public string? DrugDesc { get; set; }

    [Column("item_id")]
    [StringLength(1)]
    public string? ItemId { get; set; }

    [Column("item_desc")]
    [StringLength(35)]
    public string? ItemDesc { get; set; }

    [Column("item_no")]
    [StringLength(35)]
    public string? ItemNo { get; set; }

    [Column("code_agncy")]
    [StringLength(3)]
    public string? CodeAgncy { get; set; }

    [Column("form_code")]
    [StringLength(10)]
    public string? FormCode { get; set; }

    [Column("drug_strength")]
    [StringLength(70)]
    public string? DrugStrength { get; set; }

    [Column("drug_strength_code")]
    [StringLength(10)]
    public string? DrugStrengthCode { get; set; }

    [Column("drug_db_cd")]
    [StringLength(35)]
    public string? DrugDbCd { get; set; }

    [Column("drug_db_src")]
    [StringLength(3)]
    public string? DrugDbSrc { get; set; }

    [Column("prod_cd")]
    [StringLength(35)]
    public string? ProdCd { get; set; }

    [Column("written_dt", TypeName = "datetime")]
    public DateTime? WrittenDt { get; set; }

    [Column("qty_code")]
    [StringLength(10)]
    public string? QtyCode { get; set; }

    [Column("qty")]
    [StringLength(15)]
    public string? Qty { get; set; }

    [Column("qty_qual")]
    [StringLength(3)]
    public string? QtyQual { get; set; }

    [Column("days_supp")]
    [StringLength(4)]
    public string? DaysSupp { get; set; }

    [Column("dosage")]
    [StringLength(140)]
    public string? Dosage { get; set; }

    [Column("drug_dt_qual")]
    [StringLength(3)]
    public string? DrugDtQual { get; set; }

    [Column("drug_dt_prd")]
    [StringLength(8)]
    public string? DrugDtPrd { get; set; }

    [Column("drug_dt_prd_qual")]
    [StringLength(3)]
    public string? DrugDtPrdQual { get; set; }

    [Column("prod_sub_code")]
    [StringLength(2)]
    public string? ProdSubCode { get; set; }

    [Column("refills_unit_qual")]
    [StringLength(3)]
    public string? RefillsUnitQual { get; set; }

    [Column("refill_qty")]
    [StringLength(10)]
    public string? RefillQty { get; set; }

    [Column("ref_no")]
    [StringLength(35)]
    public string? RefNo { get; set; }

    [Column("ref_no_qual")]
    [StringLength(3)]
    public string? RefNoQual { get; set; }

    [Column("rx_note")]
    [StringLength(210)]
    public string? RxNote { get; set; }

    [Column("prior_qual")]
    [StringLength(3)]
    public string? PriorQual { get; set; }

    [Column("prior_val")]
    [StringLength(35)]
    public string? PriorVal { get; set; }

    [Column("diag1_clinic_qual")]
    [StringLength(30)]
    public string? Diag1ClinicQual { get; set; }

    [Column("diag1_dx1_qual")]
    [StringLength(10)]
    public string? Diag1Dx1Qual { get; set; }

    [Column("diag1_dx1_desc")]
    [StringLength(17)]
    public string? Diag1Dx1Desc { get; set; }

    [Column("diag1_dx2_qual")]
    [StringLength(10)]
    public string? Diag1Dx2Qual { get; set; }

    [Column("diag1_dx2_desc")]
    [StringLength(17)]
    public string? Diag1Dx2Desc { get; set; }

    [Column("diag2_clinic_qual")]
    [StringLength(30)]
    public string? Diag2ClinicQual { get; set; }

    [Column("diag2_dx1_qual")]
    [StringLength(10)]
    public string? Diag2Dx1Qual { get; set; }

    [Column("diag2_dx1_desc")]
    [StringLength(17)]
    public string? Diag2Dx1Desc { get; set; }

    [Column("diag2_dx2_qual")]
    [StringLength(10)]
    public string? Diag2Dx2Qual { get; set; }

    [Column("diag2_dx2_desc")]
    [StringLength(17)]
    public string? Diag2Dx2Desc { get; set; }

    [Column("last_fill_dt", TypeName = "datetime")]
    public DateTime? LastFillDt { get; set; }

    [Column("prod_cd_qual")]
    [StringLength(15)]
    public string? ProdCdQual { get; set; }

    [Column("erx_drug_seg_typ")]
    [StringLength(1)]
    public string? ErxDrugSegTyp { get; set; }

    [Column("dea_schedule")]
    [StringLength(10)]
    public string? DeaSchedule { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
