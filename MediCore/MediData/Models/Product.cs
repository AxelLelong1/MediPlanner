using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("product")]
public partial class Product
{
    [Key]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("product_name")]
    [StringLength(50)]
    public string ProductName { get; set; } = null!;

    [Column("product_desc")]
    [StringLength(255)]
    public string? ProductDesc { get; set; }

    [Column("product_typ")]
    public int? ProductTyp { get; set; }

    [Column("product_code")]
    [StringLength(50)]
    public string? ProductCode { get; set; }

    [Column("product_status_cd")]
    [StringLength(1)]
    public string? ProductStatusCd { get; set; }

    [Column("stock_item_id")]
    [StringLength(30)]
    public string? StockItemId { get; set; }

    [Column("agt_name")]
    [StringLength(50)]
    public string? AgtName { get; set; }

    [Column("dosage_form")]
    public int? DosageForm { get; set; }

    [Column("admn_route")]
    public int? AdmnRoute { get; set; }

    [Column("multi_use_prod_ind")]
    [StringLength(1)]
    public string? MultiUseProdInd { get; set; }

    [Column("product_vol", TypeName = "numeric(11, 4)")]
    public decimal? ProductVol { get; set; }

    [Column("product_vol_unit")]
    public int? ProductVolUnit { get; set; }

    [Column("strength")]
    [StringLength(15)]
    public string? Strength { get; set; }

    [Column("strength_unit")]
    public int? StrengthUnit { get; set; }

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

    [InverseProperty("Product")]
    public virtual ICollection<ProductBillCdXref> ProductBillCdXref { get; set; } = new List<ProductBillCdXref>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductDispLocXref> ProductDispLocXref { get; set; } = new List<ProductDispLocXref>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductFormularyAgtXref> ProductFormularyAgtXref { get; set; } = new List<ProductFormularyAgtXref>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductStorageLocXref> ProductStorageLocXref { get; set; } = new List<ProductStorageLocXref>();

    [InverseProperty("Product")]
    public virtual ICollection<StockItemBatch> StockItemBatch { get; set; } = new List<StockItemBatch>();
}
