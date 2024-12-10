using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactActivityBillingMo
{
    [Column(TypeName = "datetime")]
    public DateTime? FromDateOfService { get; set; }

    [StringLength(200)]
    public string BillEventDescription { get; set; } = null!;

    public int BillEventType { get; set; }

    [StringLength(30)]
    public string? ProcedureCode { get; set; }

    [StringLength(10)]
    public string? ProcedureCodeType { get; set; }

    public int BillEventUnits { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? ActivityCost { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? CreditAmount { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? ActualCharge { get; set; }

    [StringLength(1)]
    public string BillEventStatus { get; set; } = null!;

    [Column("BillingInventoryID")]
    [StringLength(10)]
    public string? BillingInventoryId { get; set; }

    [Column("ctrphys_stkh_id")]
    [StringLength(20)]
    public string? CtrphysStkhId { get; set; }

    [StringLength(250)]
    public string? BillItemDescription { get; set; }

    [Column("ctrndc_upc_hri_cd")]
    [StringLength(11)]
    public string? CtrndcUpcHriCd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreditedDateTime { get; set; }

    [StringLength(20)]
    public string? AllModifierCodes { get; set; }

    [Column("BillingAccountID")]
    public int? BillingAccountId { get; set; }

    [Column("ctrloc_id")]
    public int? CtrlocId { get; set; }

    [StringLength(1)]
    public string? OverrideIndicator { get; set; }

    [Column("ctrref_stkh_id")]
    [StringLength(20)]
    public string? CtrrefStkhId { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? DoseWastageAmount { get; set; }

    public int? DoseWastageUnit { get; set; }

    [Column("bill_event_typ_id")]
    public int BillEventTypId { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    [Column("ctrbill_event_id")]
    public int CtrbillEventId { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    [Column("ctrpt_visit_id")]
    public int CtrptVisitId { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("MOROIndicator")]
    [StringLength(2)]
    public string Moroindicator { get; set; } = null!;

    [Column("phys_userid")]
    [StringLength(255)]
    public string? PhysUserid { get; set; }
}
