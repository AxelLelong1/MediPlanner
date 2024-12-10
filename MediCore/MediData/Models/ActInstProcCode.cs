using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ExportedDateTime", Name = "XIE1ActInstProcCode")]
[Index("CompletedDateTime", Name = "XIE4ActInstProcCode")]
[Index("MrkdCmpltdDateTime", Name = "XIE5ActInstProcCode")]
[Index("HstryDateTime", "ProcedureCodeSer", Name = "XIE6ActInstProcCode")]
[Index("DepartmentSer", Name = "XIF1008ActInstProcCode")]
[Index("ActivityInstanceSer", "ObjectStatus", "CompletedDateTime", "MrkdCmpltdDateTime", Name = "XIF631ActInstProcCode")]
[Index("ModifierSer", Name = "XIF665ActInstProcCode")]
[Index("Modifier2Ser", Name = "XIF808ActInstProcCode")]
[Index("Modifier3Ser", Name = "XIF809ActInstProcCode")]
[Index("Modifier4Ser", Name = "XIF810ActInstProcCode")]
[Index("Modifier5Ser", Name = "XIF811ActInstProcCode")]
[Index("Modifier6Ser", Name = "XIF812ActInstProcCode")]
[Index("Modifier7Ser", Name = "XIF813ActInstProcCode")]
[Index("AccountBillingCodeSer", Name = "XIF830ActInstProcCode")]
public partial class ActInstProcCode
{
    [Key]
    public long ActInstProcCodeSer { get; set; }

    public int ActInstProcCodeRevCount { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public long ProcedureCodeSer { get; set; }

    public int ProcedureCodeRevCount { get; set; }

    public long? AccountBillingCodeSer { get; set; }

    public int? AccountBillingCodeRevCount { get; set; }

    public long? ModifierSer { get; set; }

    public int? ActivityCodeMdRevCount { get; set; }

    [StringLength(64)]
    public string? Modifier { get; set; }

    public long? Modifier2Ser { get; set; }

    public int? ActivityCodeMd2RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier2 { get; set; }

    public long? Modifier3Ser { get; set; }

    public int? ActivityCodeMd3RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier3 { get; set; }

    public long? Modifier4Ser { get; set; }

    public int? ActivityCodeMd4RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier4 { get; set; }

    public long? Modifier5Ser { get; set; }

    public int? ActivityCodeMd5RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier5 { get; set; }

    public long? Modifier6Ser { get; set; }

    public int? ActivityCodeMd6RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier6 { get; set; }

    public long? Modifier7Ser { get; set; }

    public int? ActivityCodeMd7RevCount { get; set; }

    [StringLength(64)]
    public string? Modifier7 { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string? ChargeWaivedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDateOfService { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDateOfService { get; set; }

    [StringLength(255)]
    public string? CompletedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDateTime { get; set; }

    [StringLength(255)]
    public string? MrkdCmpltdBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MrkdCmpltdDateTime { get; set; }

    [StringLength(255)]
    public string? ReviewedBy { get; set; }

    [StringLength(255)]
    public string? ExportedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExportedDateTime { get; set; }

    [StringLength(255)]
    public string? ReviewResetBy { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? DepartmentSer { get; set; }

    public int? WeeklyChrgFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [ForeignKey("AccountBillingCodeSer")]
    [InverseProperty("ActInstProcCode")]
    public virtual AccountBillingCode? AccountBillingCodeSerNavigation { get; set; }

    [InverseProperty("ActInstProcCodeSerNavigation")]
    public virtual ICollection<ActInstProcCodeMh> ActInstProcCodeMh { get; set; } = new List<ActInstProcCodeMh>();

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ActInstProcCode")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [InverseProperty("ActInstProcCodeSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("ActInstProcCodeSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [InverseProperty("ActInstProcCodeSerNavigation")]
    public virtual ICollection<BillSysSentCharges> BillSysSentCharges { get; set; } = new List<BillSysSentCharges>();

    [InverseProperty("ActInstProcCodeSerNavigation")]
    public virtual ICollection<Credit> Credit { get; set; } = new List<Credit>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ActInstProcCode")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("Modifier2Ser")]
    [InverseProperty("ActInstProcCodeModifier2SerNavigation")]
    public virtual ActivityCodeMd? Modifier2SerNavigation { get; set; }

    [ForeignKey("Modifier3Ser")]
    [InverseProperty("ActInstProcCodeModifier3SerNavigation")]
    public virtual ActivityCodeMd? Modifier3SerNavigation { get; set; }

    [ForeignKey("Modifier4Ser")]
    [InverseProperty("ActInstProcCodeModifier4SerNavigation")]
    public virtual ActivityCodeMd? Modifier4SerNavigation { get; set; }

    [ForeignKey("Modifier5Ser")]
    [InverseProperty("ActInstProcCodeModifier5SerNavigation")]
    public virtual ActivityCodeMd? Modifier5SerNavigation { get; set; }

    [ForeignKey("Modifier6Ser")]
    [InverseProperty("ActInstProcCodeModifier6SerNavigation")]
    public virtual ActivityCodeMd? Modifier6SerNavigation { get; set; }

    [ForeignKey("Modifier7Ser")]
    [InverseProperty("ActInstProcCodeModifier7SerNavigation")]
    public virtual ActivityCodeMd? Modifier7SerNavigation { get; set; }

    [ForeignKey("ModifierSer")]
    [InverseProperty("ActInstProcCodeModifierSerNavigation")]
    public virtual ActivityCodeMd? ModifierSerNavigation { get; set; }

    [ForeignKey("ProcedureCodeSer")]
    [InverseProperty("ActInstProcCode")]
    public virtual ProcedureCode ProcedureCodeSerNavigation { get; set; } = null!;

    [InverseProperty("ActInstProcCodeSerNavigation")]
    public virtual ICollection<WeeklyChargeLink> WeeklyChargeLink { get; set; } = new List<WeeklyChargeLink>();
}
