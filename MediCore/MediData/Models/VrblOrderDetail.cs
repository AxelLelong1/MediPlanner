using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "VrblId", "VrblOrderDetailId")]
[Table("vrbl_order_detail")]
public partial class VrblOrderDetail
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("vrbl_id")]
    public int VrblId { get; set; }

    [Key]
    [Column("vrbl_order_detail_id")]
    public int VrblOrderDetailId { get; set; }

    [Column("po_desc")]
    [StringLength(255)]
    public string PoDesc { get; set; } = null!;

    [Column("inst_po_id")]
    public int? InstPoId { get; set; }

    [Column("po_details")]
    [StringLength(255)]
    public string? PoDetails { get; set; }

    [Column("po_cat")]
    [StringLength(40)]
    public string? PoCat { get; set; }

    [Column("po_desc_txt")]
    public string? PoDescTxt { get; set; }

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

    [ForeignKey("PtId, VrblId")]
    [InverseProperty("VrblOrderDetail")]
    public virtual VrblOrder VrblOrder { get; set; } = null!;
}
