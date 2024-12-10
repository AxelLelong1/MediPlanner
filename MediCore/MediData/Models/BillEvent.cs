using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "BillEventId", "PtVisitId")]
[Table("bill_event")]
[Index("BillEventDate", Name = "nc1_bill_event")]
[Index("PtId", "PtVisitId", "BillEventDate", Name = "nc2_bill_event")]
[Index("ChargeDate", Name = "nc3_bill_event")]
[Index("TransLogMtstamp", "TransTrfTstamp", Name = "nc4_bill_event")]
[Index("PtId", "PtVisitId", "BillEventDate", "TransLogMtstamp", "TransTrfTstamp", Name = "nc5_bill_event")]
[Index("BillEventStatus", "TransLogMtstamp", "TransTrfTstamp", Name = "nc6_bill_event")]
[Index("BillEventStatus", "BillEventTypId", "PhysUserid", "PhysInstId", "BillEventDate", Name = "nc7_bill_event")]
[Index("BillInstId", "PhysInstId", "PhysUserid", "BillEventDate", Name = "nc8_bill_event")]
public partial class BillEvent
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("bill_event_id")]
    public int BillEventId { get; set; }

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("bill_event_date", TypeName = "datetime")]
    public DateTime BillEventDate { get; set; }

    [Column("bill_event_desc")]
    [StringLength(200)]
    public string BillEventDesc { get; set; } = null!;

    [Column("bill_event_typ_id")]
    public int BillEventTypId { get; set; }

    [Column("bill_event_bill_cd")]
    [StringLength(30)]
    public string? BillEventBillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }

    [Column("bill_event_units")]
    public int BillEventUnits { get; set; }

    [Column("bill_event_mod")]
    [StringLength(3)]
    public string? BillEventMod { get; set; }

    [Column("bill_cd_est_cost", TypeName = "numeric(8, 2)")]
    public decimal? BillCdEstCost { get; set; }

    [Column("bill_cd_bill_price", TypeName = "numeric(8, 2)")]
    public decimal? BillCdBillPrice { get; set; }

    [Column("bill_event_status")]
    [StringLength(1)]
    public string BillEventStatus { get; set; } = null!;

    [Column("bill_cd_inv_id")]
    [StringLength(10)]
    public string? BillCdInvId { get; set; }

    [Column("phys_inst_id")]
    [StringLength(30)]
    public string? PhysInstId { get; set; }

    [Column("phys_userid")]
    [StringLength(255)]
    public string? PhysUserid { get; set; }

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

    [Column("actual_cost", TypeName = "numeric(8, 2)")]
    public decimal? ActualCost { get; set; }

    [Column("actual_received", TypeName = "numeric(8, 2)")]
    public decimal? ActualReceived { get; set; }

    [Column("bill_instance_id")]
    public int? BillInstanceId { get; set; }

    [Column("bill_item_desc")]
    [StringLength(250)]
    public string? BillItemDesc { get; set; }

    [Column("billed_ind")]
    [StringLength(1)]
    public string? BilledInd { get; set; }

    [Column("bill_reversal_id")]
    public int? BillReversalId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("trans_id")]
    [StringLength(12)]
    public string? TransId { get; set; }

    [Column("bill_generated_ind")]
    [StringLength(1)]
    public string? BillGeneratedInd { get; set; }

    [Column("ndc_upc_hri_cd")]
    [StringLength(11)]
    public string? NdcUpcHriCd { get; set; }

    [Column("elapsed_admn_time")]
    public int? ElapsedAdmnTime { get; set; }

    [Column("charge_date", TypeName = "datetime")]
    public DateTime? ChargeDate { get; set; }

    [Column("bill_event_link_cd")]
    [StringLength(1)]
    public string? BillEventLinkCd { get; set; }

    [Column("bill_inst_id")]
    [StringLength(30)]
    public string? BillInstId { get; set; }

    [Column("bill_modifier")]
    [StringLength(20)]
    public string? BillModifier { get; set; }

    [Column("bill_acct_id")]
    public int? BillAcctId { get; set; }

    [Column("loc_id")]
    public int? LocId { get; set; }

    [Column("override_ind")]
    [StringLength(1)]
    public string? OverrideInd { get; set; }

    [Column("spsr_stkh_id")]
    [StringLength(20)]
    public string? SpsrStkhId { get; set; }

    [Column("ref_pt_provider_id")]
    public int? RefPtProviderId { get; set; }

    [Column("dose_wastage_amt", TypeName = "numeric(11, 4)")]
    public decimal? DoseWastageAmt { get; set; }

    [Column("dose_wastage_unit")]
    public int? DoseWastageUnit { get; set; }

    [ForeignKey("BillCdTypId")]
    [InverseProperty("BillEvent")]
    public virtual BillCdTyp? BillCdTyp { get; set; }

    [InverseProperty("BillEvent")]
    public virtual ICollection<BillEventActual> BillEventActual { get; set; } = new List<BillEventActual>();

    [InverseProperty("BillEvent")]
    public virtual BillEventEmInfo? BillEventEmInfo { get; set; }

    [ForeignKey("BillEventTypId")]
    [InverseProperty("BillEvent")]
    public virtual BillEventTyp BillEventTyp { get; set; } = null!;

    [InverseProperty("BillEvent")]
    public virtual XrefBillEventPrecert? XrefBillEventPrecert { get; set; }

    [InverseProperty("BillEvent")]
    public virtual ICollection<XrefDxBillEvent> XrefDxBillEvent { get; set; } = new List<XrefDxBillEvent>();
}
