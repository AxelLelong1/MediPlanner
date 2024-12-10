using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StockBatchId", "StorageLocId")]
[Table("stock_item_batch_loc_xref")]
public partial class StockItemBatchLocXref
{
    [Key]
    [Column("stock_batch_id")]
    public int StockBatchId { get; set; }

    [Key]
    [Column("storage_loc_id")]
    public int StorageLocId { get; set; }

    [Column("stock_qty")]
    public int? StockQty { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("StockBatchId")]
    [InverseProperty("StockItemBatchLocXref")]
    public virtual StockItemBatch StockBatch { get; set; } = null!;

    [ForeignKey("StorageLocId")]
    [InverseProperty("StockItemBatchLocXref")]
    public virtual StorageLoc StorageLoc { get; set; } = null!;
}
