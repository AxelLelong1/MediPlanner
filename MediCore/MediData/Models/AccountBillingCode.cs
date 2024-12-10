using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", Name = "XIF488AccountBillingCode")]
[Index("DepartmentSer", Name = "XIF832AccountBillingCode")]
[Index("HospitalSer", Name = "XIF833AccountBillingCode")]
[Index("AttendingOncologistSer", Name = "XIF834AccountBillingCode")]
[Index("ReferringDoctorSer", Name = "XIF836AccountBillingCode")]
public partial class AccountBillingCode
{
    [Key]
    public long AccountBillingCodeSer { get; set; }

    public long PatientSer { get; set; }

    public int AccountBillingCodeRevCount { get; set; }

    [StringLength(20)]
    public string AccountBillingCodeId { get; set; } = null!;

    public long? HospitalSer { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(254)]
    public string? BillAccountName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [StringLength(16)]
    public string? ObjectStatus { get; set; }

    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    public long? AttendingOncologistSer { get; set; }

    public long? ReferringDoctorSer { get; set; }

    public int? InPatientFlag { get; set; }

    [StringLength(64)]
    public string? IntfExternalField1 { get; set; }

    [StringLength(64)]
    public string? IntfExternalField2 { get; set; }

    [StringLength(64)]
    public string? IntfExternalField3 { get; set; }

    [StringLength(64)]
    public string? IntfExternalField4 { get; set; }

    [StringLength(64)]
    public string? IntfExternalField5 { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("AccountBillingCodeSerNavigation")]
    public virtual ICollection<AccountBillingCodeMh> AccountBillingCodeMh { get; set; } = new List<AccountBillingCodeMh>();

    [InverseProperty("AccountBillingCodeSerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCode { get; set; } = new List<ActInstProcCode>();

    [ForeignKey("AttendingOncologistSer")]
    [InverseProperty("AccountBillingCodeAttendingOncologistSerNavigation")]
    public virtual Doctor? AttendingOncologistSerNavigation { get; set; }

    [InverseProperty("AccountBillingCodeSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("AccountBillingCodeSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("AccountBillingCode")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("HospitalSer")]
    [InverseProperty("AccountBillingCode")]
    public virtual Hospital? HospitalSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("AccountBillingCode")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [ForeignKey("ReferringDoctorSer")]
    [InverseProperty("AccountBillingCodeReferringDoctorSerNavigation")]
    public virtual Doctor? ReferringDoctorSerNavigation { get; set; }
}
