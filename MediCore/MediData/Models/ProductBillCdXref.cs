using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("product_bill_cd_xref")]
public partial class ProductBillCdXref
{
    [Key]
    [Column("product_bill_cd_id")]
    public int ProductBillCdId { get; set; }

    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string? BillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }

    [Column("bill_qty", TypeName = "numeric(7, 2)")]
    public decimal? BillQty { get; set; }

    [Column("unit_amt", TypeName = "numeric(11, 2)")]
    public decimal? UnitAmt { get; set; }

    [Column("unit_uom")]
    public int? UnitUom { get; set; }

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

    [ForeignKey("InstId")]
    [InverseProperty("ProductBillCdXref")]
    public virtual Inst? Inst { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductBillCdXref")]
    public virtual Product Product { get; set; } = null!;
}
