using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stock_trx")]
public partial class StockTrx
{
    [Key]
    [Column("stock_trx_id")]
    public int StockTrxId { get; set; }

    [Column("disp_loc_id")]
    public int DispLocId { get; set; }

    [Column("storage_loc_id")]
    public int? StorageLocId { get; set; }

    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("stock_trx_typ")]
    public int StockTrxTyp { get; set; }

    [Column("stock_trx_date", TypeName = "datetime")]
    public DateTime? StockTrxDate { get; set; }

    [Column("trx_qty", TypeName = "decimal(11, 4)")]
    public decimal? TrxQty { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("disp_id")]
    public int? DispId { get; set; }

    [Column("rx_hydra_disp_id")]
    public int? RxHydraDispId { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("product_size")]
    [StringLength(15)]
    public string? ProductSize { get; set; }

    [Column("product_size_unit")]
    public int? ProductSizeUnit { get; set; }

    [Column("drug_batch_id")]
    public int? DrugBatchId { get; set; }

    [Column("drug_batch_agt_id")]
    public int? DrugBatchAgtId { get; set; }

    [Column("drug_batch_diluent_ind")]
    [StringLength(1)]
    public string? DrugBatchDiluentInd { get; set; }

    [ForeignKey("DrugBatchId")]
    [InverseProperty("StockTrx")]
    public virtual DrugBatch? DrugBatch { get; set; }

    [ForeignKey("DrugBatchAgtId")]
    [InverseProperty("StockTrx")]
    public virtual DrugBatchAgt? DrugBatchAgt { get; set; }
}
