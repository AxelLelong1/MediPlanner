using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvBillingCode
{
    [StringLength(30)]
    public string? BillingCode { get; set; }

    [StringLength(250)]
    public string? BillingCodeDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BillingCodeEffectiveDate { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? BillingCodeEstCost { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? BillingCodeBillPrice { get; set; }

    [StringLength(10)]
    public string? BillingCodeType { get; set; }

    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChangeDate { get; set; }

    [StringLength(30)]
    public string? FacilityBillCode { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string ObjectStatus { get; set; } = null!;
}
