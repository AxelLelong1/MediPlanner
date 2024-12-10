using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stock_item_batch")]
public partial class StockItemBatch
{
    [Key]
    [Column("stock_item_batch_id")]
    public int StockItemBatchId { get; set; }

    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("grp_ind")]
    [StringLength(1)]
    public string GrpInd { get; set; } = null!;

    [Column("lot_no")]
    [StringLength(50)]
    public string? LotNo { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("expiry_date_cd")]
    public int? ExpiryDateCd { get; set; }

    [Column("serial_no")]
    [StringLength(40)]
    public string? SerialNo { get; set; }

    [Column("batch_status_typ")]
    public int? BatchStatusTyp { get; set; }

    [Column("loaded_date", TypeName = "datetime")]
    public DateTime? LoadedDate { get; set; }

    [Column("group_qty")]
    public int? GroupQty { get; set; }

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

    [ForeignKey("ProductId")]
    [InverseProperty("StockItemBatch")]
    public virtual Product Product { get; set; } = null!;

    [InverseProperty("StockBatch")]
    public virtual ICollection<StockItemBatchLocXref> StockItemBatchLocXref { get; set; } = new List<StockItemBatchLocXref>();
}
