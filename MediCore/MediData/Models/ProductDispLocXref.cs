﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ProductId", "DispLocId")]
[Table("product_disp_loc_xref")]
public partial class ProductDispLocXref
{
    [Key]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Key]
    [Column("disp_loc_id")]
    public int DispLocId { get; set; }

    [Column("stock_qty", TypeName = "decimal(11, 4)")]
    public decimal? StockQty { get; set; }

    [Column("reorder_threshold")]
    public int? ReorderThreshold { get; set; }

    [Column("product_disp_loc_cd")]
    [StringLength(30)]
    public string? ProductDispLocCd { get; set; }

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
    [InverseProperty("ProductDispLocXref")]
    public virtual DispLoc DispLoc { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("ProductDispLocXref")]
    public virtual Product Product { get; set; } = null!;
}
