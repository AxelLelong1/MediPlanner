using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AccountBillingCodeSer", "AccountBillingCodeRevCount")]
[Table("AccountBillingCodeMH")]
[Index("PatientSer", Name = "XIE1AccountBillingCodeMH")]
public partial class AccountBillingCodeMh
{
    [Key]
    public long AccountBillingCodeSer { get; set; }

    [Key]
    public int AccountBillingCodeRevCount { get; set; }

    public long PatientSer { get; set; }

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

    [ForeignKey("AccountBillingCodeSer")]
    [InverseProperty("AccountBillingCodeMh")]
    public virtual AccountBillingCode AccountBillingCodeSerNavigation { get; set; } = null!;
}
