using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPhysicianOrder
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("vrbl_id")]
    public int VrblId { get; set; }

    [Column("vrbl_order_detail_id")]
    public int? VrblOrderDetailId { get; set; }

    [StringLength(1)]
    public string? AppliedIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppliedDateTime { get; set; }

    [Column("AppliedDateTimeID")]
    public int? AppliedDateTimeId { get; set; }

    [StringLength(3000)]
    public string? AppliedText { get; set; }

    [StringLength(255)]
    public string? AppliedUserId { get; set; }

    [StringLength(30)]
    public string? AppliedInstituteId { get; set; }

    [StringLength(1)]
    public string? ApprovedOnFileIndicator { get; set; }

    [StringLength(1)]
    public string? CancelEntryIndicator { get; set; }

    [StringLength(1)]
    public string? CompletedIndicator { get; set; }

    [StringLength(20)]
    public string? TpName { get; set; }

    [StringLength(10)]
    public string? TpVersionNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TpInitDateTime { get; set; }

    [Column("TPinitDateTimeID")]
    public int? TpinitDateTimeId { get; set; }

    [StringLength(40)]
    public string? ExternalTpName { get; set; }

    [StringLength(1)]
    public string? GeneratedIndicator { get; set; }

    [Column("dx_id")]
    public int? DxId { get; set; }

    public int? OrderType { get; set; }

    [StringLength(20)]
    public string? PlacerOrderNumber { get; set; }

    [StringLength(1)]
    public string? PlanAffectIndicator { get; set; }

    public int? PhysicianOrderSheetId { get; set; }

    [StringLength(40)]
    public string? PhysicianOrderSheetDesc { get; set; }

    public int? PhysicianOrderTime { get; set; }

    public int? PhysicianOrderTimeFrame { get; set; }

    [Column("PhysicianOrderTimeFrameDateID")]
    public int? PhysicianOrderTimeFrameDateId { get; set; }

    [Column("POTimeFrameDateTime", TypeName = "datetime")]
    public DateTime? PotimeFrameDateTime { get; set; }

    [StringLength(1)]
    public string? RecurringIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransLogModifiedDateTime { get; set; }

    [StringLength(255)]
    public string TransLogModifiedUserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransLogDateTime { get; set; }

    [StringLength(255)]
    public string? TransLogUserId { get; set; }

    [StringLength(30)]
    public string? TransLogInstituteId { get; set; }

    [StringLength(1)]
    public string? VerbalOrderValidEntryIndicator { get; set; }

    [StringLength(1)]
    public string? VerbalOrderApprovalFlag { get; set; }

    [Column("VerbalApprovedDateTimeID")]
    public int? VerbalApprovedDateTimeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerbalApprovalDateTime { get; set; }

    [StringLength(3000)]
    public string? VerbalApprovalText { get; set; }

    [StringLength(255)]
    public string? VerbalComment { get; set; }

    [StringLength(30)]
    public string? VerbalInstituteId { get; set; }

    [StringLength(1)]
    public string? DisplaySourceType { get; set; }

    [Column("VerbalDateTimeID")]
    public int? VerbalDateTimeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VerbalDateTime { get; set; }

    [StringLength(3000)]
    public string? VerbalText { get; set; }

    [StringLength(1)]
    public string? VerbalType { get; set; }

    [StringLength(40)]
    public string? VerbalTypeDesc { get; set; }

    [StringLength(255)]
    public string? VerbalUserId { get; set; }

    [StringLength(255)]
    public string? PhysicianOrderDescription { get; set; }

    [StringLength(255)]
    public string? PhysicianOrderDetails { get; set; }

    [StringLength(40)]
    public string? PhysicianOrderCategory { get; set; }

    [StringLength(3000)]
    public string? PhysicianOrderDescText { get; set; }
}
