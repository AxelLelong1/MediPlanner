using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_refill_detail")]
[Index("RxRefNo", "RefillSeg", "Attribute", "ProcInd", Name = "nc1_erx_refill_detail")]
[Index("ProcInd", Name = "nc2_erx_refill_detail")]
public partial class ErxRefillDetail
{
    [Key]
    [Column("erx_refill_detail_id")]
    public int ErxRefillDetailId { get; set; }

    [Column("rx_ref_no")]
    [StringLength(35)]
    public string RxRefNo { get; set; } = null!;

    [Column("refill_seg")]
    [StringLength(25)]
    public string RefillSeg { get; set; } = null!;

    [Column("attribute")]
    [StringLength(30)]
    public string Attribute { get; set; } = null!;

    [Column("attr_value")]
    [StringLength(210)]
    public string AttrValue { get; set; } = null!;

    [Column("group_no")]
    public int? GroupNo { get; set; }

    [Column("proc_ind")]
    [StringLength(1)]
    public string? ProcInd { get; set; }
}
