using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActInstProcCodeSer", Name = "XIF777BillSysSentCharges")]
[Index("PatientSer", Name = "XIF778BillSysSentCharges")]
public partial class BillSysSentCharges
{
    [Key]
    public long BillSysSentChargesSer { get; set; }

    [StringLength(16)]
    public string TransId { get; set; } = null!;

    public long ActInstProcCodeSer { get; set; }

    public int ActInstProcCodeRevCount { get; set; }

    [StringLength(16)]
    public string ChargeIndicator { get; set; } = null!;

    [StringLength(1)]
    public string VoidCharge { get; set; } = null!;

    [StringLength(64)]
    public string BillSysInstId { get; set; } = null!;

    [StringLength(64)]
    public string BillSysId { get; set; } = null!;

    public long? PatientSer { get; set; }

    [StringLength(1)]
    public string? MergeFlag { get; set; }

    [StringLength(16)]
    public string? BatchId { get; set; }

    [StringLength(32)]
    public string? Hl7MsgCntlId { get; set; }

    public int? Hl7SetId { get; set; }

    [StringLength(16)]
    public string? FillerRefNo { get; set; }

    public int? BillEventUnits { get; set; }

    [Column(TypeName = "money")]
    public decimal? BillCdBillPrice { get; set; }

    [StringLength(16)]
    public string? BillCdInvId { get; set; }

    [StringLength(1)]
    public string? SendSurpressed { get; set; }

    [StringLength(1)]
    public string BillChargeStatus { get; set; } = null!;

    [StringLength(254)]
    public string? BillChargeStatusTxt { get; set; }

    [ForeignKey("ActInstProcCodeSer")]
    [InverseProperty("BillSysSentCharges")]
    public virtual ActInstProcCode ActInstProcCodeSerNavigation { get; set; } = null!;

    [ForeignKey("PatientSer")]
    [InverseProperty("BillSysSentCharges")]
    public virtual Patient? PatientSerNavigation { get; set; }
}
