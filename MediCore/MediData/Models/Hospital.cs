using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HospitalName", Name = "XAK1Hospital", IsUnique = true)]
[Index("AddressSer", Name = "XIF668Hospital")]
public partial class Hospital
{
    [Key]
    public long HospitalSer { get; set; }

    [StringLength(64)]
    public string HospitalName { get; set; } = null!;

    public long? AddressSer { get; set; }

    [StringLength(64)]
    public string HospitalLocation { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(64)]
    public string? Organization { get; set; }

    [StringLength(64)]
    public string? WebAddress { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Logo { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? MailServerAddress { get; set; }

    [StringLength(254)]
    public string? MailUserName { get; set; }

    [StringLength(254)]
    public string? MailPassword { get; set; }

    public int? MailPortNumber { get; set; }

    [Column("MailSSLFlag")]
    public int MailSslflag { get; set; }

    public int MailAnonymousFlag { get; set; }

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<AccountBillingCode> AccountBillingCode { get; set; } = new List<AccountBillingCode>();

    [ForeignKey("AddressSer")]
    [InverseProperty("Hospital")]
    public virtual Address? AddressSerNavigation { get; set; }

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<BillSysHospDeptActivity> BillSysHospDeptActivity { get; set; } = new List<BillSysHospDeptActivity>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<ChargesControl> ChargesControl { get; set; } = new List<ChargesControl>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<CompliancePeriodHospital> CompliancePeriodHospital { get; set; } = new List<CompliancePeriodHospital>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<Department> Department { get; set; } = new List<Department>();

    [InverseProperty("CtrHospitalSerNavigation")]
    public virtual ICollection<InSightiveSimplifiedHospDeptConfigurationTb> InSightiveSimplifiedHospDeptConfigurationTb { get; set; } = new List<InSightiveSimplifiedHospDeptConfigurationTb>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<PatientHospital> PatientHospital { get; set; } = new List<PatientHospital>();

    [InverseProperty("HospitalSerNavigation")]
    public virtual ICollection<Transportation> Transportation { get; set; } = new List<Transportation>();
}
