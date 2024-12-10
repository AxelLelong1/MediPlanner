using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("storage_loc")]
public partial class StorageLoc
{
    [Key]
    [Column("storage_loc_id")]
    public int StorageLocId { get; set; }

    [Column("storage_loc_name")]
    [StringLength(50)]
    public string StorageLocName { get; set; } = null!;

    [Column("storage_loc_desc")]
    [StringLength(255)]
    public string? StorageLocDesc { get; set; }

    [Column("storage_loc_typ")]
    public int StorageLocTyp { get; set; }

    [Column("storage_cls_typ")]
    public int StorageClsTyp { get; set; }

    [Column("parent_storage_loc_id")]
    public int? ParentStorageLocId { get; set; }

    [Column("storage_loc_map_id")]
    [StringLength(30)]
    public string? StorageLocMapId { get; set; }

    [Column("storage_loc_label")]
    [StringLength(30)]
    public string? StorageLocLabel { get; set; }

    [Column("disp_loc_id")]
    public int? DispLocId { get; set; }

    [Column("product_storage_ind")]
    [StringLength(1)]
    public string ProductStorageInd { get; set; } = null!;

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

    [ForeignKey("DispLocId")]
    [InverseProperty("StorageLoc")]
    public virtual DispLoc? DispLoc { get; set; }

    [InverseProperty("StorageLoc")]
    public virtual ICollection<ProductStorageLocXref> ProductStorageLocXref { get; set; } = new List<ProductStorageLocXref>();

    [InverseProperty("StorageLoc")]
    public virtual ICollection<StockItemBatchLocXref> StockItemBatchLocXref { get; set; } = new List<StockItemBatchLocXref>();
}
