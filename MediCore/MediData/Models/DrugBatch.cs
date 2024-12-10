using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("drug_batch")]
[Index("DrugBatchInstId", Name = "nc1_drug_batch")]
public partial class DrugBatch
{
    [Key]
    [Column("drug_batch_id")]
    public int DrugBatchId { get; set; }

    [Column("drug_batch_desc")]
    [StringLength(255)]
    public string DrugBatchDesc { get; set; } = null!;

    [Column("prep_date", TypeName = "datetime")]
    public DateTime PrepDate { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("expiry_override_ind")]
    [StringLength(1)]
    public string? ExpiryOverrideInd { get; set; }

    [Column("expiry_override_cmt")]
    [StringLength(255)]
    public string? ExpiryOverrideCmt { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("prepared_ind")]
    [StringLength(1)]
    public string? PreparedInd { get; set; }

    [Column("no_of_units")]
    public int? NoOfUnits { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("lbl_cnt_orig")]
    public int? LblCntOrig { get; set; }

    [Column("lbl_cnt_extra")]
    public int? LblCntExtra { get; set; }

    [Column("wrksht_cnt")]
    public int? WrkshtCnt { get; set; }

    [Column("admn_route")]
    public int AdmnRoute { get; set; }

    [Column("total_dose", TypeName = "numeric(11, 4)")]
    public decimal? TotalDose { get; set; }

    [Column("total_vol", TypeName = "numeric(11, 4)")]
    public decimal? TotalVol { get; set; }

    [Column("total_dose_uom")]
    public int? TotalDoseUom { get; set; }

    [Column("total_vol_uom")]
    public int? TotalVolUom { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("disp_loc_id")]
    public int? DispLocId { get; set; }

    [Column("hydra_fluid_id")]
    public int? HydraFluidId { get; set; }

    [Column("hydra_vol", TypeName = "numeric(11, 4)")]
    public decimal? HydraVol { get; set; }

    [Column("hydra_vol_uom")]
    public int? HydraVolUom { get; set; }

    [Column("master_lbl_desc")]
    public string? MasterLblDesc { get; set; }

    [Column("sys_gen_expiry_date", TypeName = "datetime")]
    public DateTime? SysGenExpiryDate { get; set; }

    [Column("drug_batch_dest")]
    [StringLength(50)]
    public string? DrugBatchDest { get; set; }

    [Column("drug_batch_inst_id")]
    [StringLength(30)]
    public string? DrugBatchInstId { get; set; }

    [Column("addl_lbl_dtl")]
    [StringLength(255)]
    public string? AddlLblDtl { get; set; }

    [InverseProperty("DrugBatch")]
    public virtual ICollection<DrugBatchAgt> DrugBatchAgt { get; set; } = new List<DrugBatchAgt>();

    [InverseProperty("DrugBatch")]
    public virtual ICollection<DrugBatchPrint> DrugBatchPrint { get; set; } = new List<DrugBatchPrint>();

    [InverseProperty("DrugBatch")]
    public virtual ICollection<DrugBatchPrintLblDtl> DrugBatchPrintLblDtl { get; set; } = new List<DrugBatchPrintLblDtl>();

    [InverseProperty("DrugBatch")]
    public virtual ICollection<DrugBatchUnit> DrugBatchUnit { get; set; } = new List<DrugBatchUnit>();

    [InverseProperty("DrugBatch")]
    public virtual ICollection<StockTrx> StockTrx { get; set; } = new List<StockTrx>();
}
