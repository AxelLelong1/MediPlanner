using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DoctorId", Name = "XAK1Doctor", IsUnique = true)]
[Index("AliasName", Name = "XAK2Doctor", IsUnique = true)]
[Index("LastName", "FirstName", "MiddleName", "OncologistFlag", Name = "XIE1Doctor")]
[Index("OncologistFlag", "LastName", "FirstName", "MiddleName", Name = "XIE2Doctor")]
public partial class Doctor
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string DoctorId { get; set; } = null!;

    [StringLength(16)]
    public string? Honorific { get; set; }

    [StringLength(64)]
    public string FirstName { get; set; } = null!;

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(64)]
    public string AliasName { get; set; } = null!;

    [StringLength(64)]
    public string? Specialty { get; set; }

    [StringLength(64)]
    public string? Institution { get; set; }

    public int OncologistFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    public int ExternalMedOncFlag { get; set; }

    [InverseProperty("AttendingOncologistSerNavigation")]
    public virtual ICollection<AccountBillingCode> AccountBillingCodeAttendingOncologistSerNavigation { get; set; } = new List<AccountBillingCode>();

    [InverseProperty("ReferringDoctorSerNavigation")]
    public virtual ICollection<AccountBillingCode> AccountBillingCodeReferringDoctorSerNavigation { get; set; } = new List<AccountBillingCode>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<ActivityCapture> ActivityCapture { get; set; } = new List<ActivityCapture>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<DoctorBillingService> DoctorBillingService { get; set; } = new List<DoctorBillingService>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<DoctorMh> DoctorMh { get; set; } = new List<DoctorMh>();

    [InverseProperty("CtrResourceSerNavigation")]
    public virtual ICollection<InSightiveSimplifiedPrimaryOncoConfigurationTb> InSightiveSimplifiedPrimaryOncoConfigurationTb { get; set; } = new List<InSightiveSimplifiedPrimaryOncoConfigurationTb>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<PatientDoctor> PatientDoctor { get; set; } = new List<PatientDoctor>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Doctor")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
