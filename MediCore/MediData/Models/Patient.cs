using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientId", Name = "XAK1Patient", IsUnique = true)]
[Index("PatientUid", Name = "XAK2Patient", IsUnique = true)]
[Index("PatientId2", "MiddleName", Name = "XIE1Patient")]
[Index("HstryDateTime", Name = "XIE2Patient")]
[Index("LastName", "FirstName", Name = "XIE3Patient")]
[Index("Ssn", Name = "XIE4Patient_Filtered_SSN")]
[Index("MobilePhoneProviderSer", Name = "XIF1Patient")]
public partial class Patient
{
    [Key]
    public long PatientSer { get; set; }

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [Column("PatientUID")]
    [StringLength(64)]
    public string PatientUid { get; set; } = null!;

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [Column("SSN")]
    [StringLength(64)]
    public string? Ssn { get; set; }

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(16)]
    public string? Honorific { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    [StringLength(64)]
    public string? WorkPhone { get; set; }

    [StringLength(64)]
    public string? HomePhone { get; set; }

    [StringLength(64)]
    public string? Citizenship { get; set; }

    [StringLength(64)]
    public string? Race { get; set; }

    [StringLength(64)]
    public string? BirthCountry { get; set; }

    [StringLength(64)]
    public string? BirthState { get; set; }

    [StringLength(64)]
    public string? BirthCounty { get; set; }

    [StringLength(64)]
    public string? BirthCity { get; set; }

    [StringLength(255)]
    public string? PatientIdIssuer { get; set; }

    [StringLength(64)]
    public string? MaidenName { get; set; }

    [StringLength(64)]
    public string? MothersMaidenName { get; set; }

    [StringLength(64)]
    public string? MedRecordLocator { get; set; }

    [StringLength(64)]
    public string? Language { get; set; }

    [StringLength(64)]
    public string? Occupation { get; set; }

    [StringLength(64)]
    public string? SpecialNeeds { get; set; }

    [StringLength(64)]
    public string? ReligiousPreference { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArchiveDate { get; set; }

    [StringLength(32)]
    public string? ArchiveVolume { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int ClinicalTrialFlag { get; set; }

    [Column("FileDataSiteID")]
    [StringLength(254)]
    public string? FileDataSiteId { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? MobilePhone { get; set; }

    [StringLength(64)]
    public string? Ethnicity { get; set; }

    public long? MobilePhoneProviderSer { get; set; }

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<AccessStatus> AccessStatus { get; set; } = new List<AccessStatus>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<AccountBillingCode> AccountBillingCode { get; set; } = new List<AccountBillingCode>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Adt08> Adt08 { get; set; } = new List<Adt08>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<ArchiveRestoredFile> ArchiveRestoredFile { get; set; } = new List<ArchiveRestoredFile>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<BillSysSentCharges> BillSysSentCharges { get; set; } = new List<BillSysSentCharges>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<ChartQa> ChartQa { get; set; } = new List<ChartQa>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Course> Course { get; set; } = new List<Course>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Employer> Employer { get; set; } = new List<Employer>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Image1> Image1 { get; set; } = new List<Image1>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Image4D> Image4D { get; set; } = new List<Image4D>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<InVivoDosimetry> InVivoDosimetry { get; set; } = new List<InVivoDosimetry>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<LtascheduledTaskPatient> LtascheduledTaskPatient { get; set; } = new List<LtascheduledTaskPatient>();

    [ForeignKey("MobilePhoneProviderSer")]
    [InverseProperty("Patient")]
    public virtual MobilePhoneProvider? MobilePhoneProviderSerNavigation { get; set; }

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<NonScheduledActivity> NonScheduledActivity { get; set; } = new List<NonScheduledActivity>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<ObsoleteObject> ObsoleteObject { get; set; } = new List<ObsoleteObject>();

    [InverseProperty("PatientSerNavigation")]
    public virtual PatientActuals? PatientActuals { get; set; }

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientAddress> PatientAddress { get; set; } = new List<PatientAddress>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientDepartment> PatientDepartment { get; set; } = new List<PatientDepartment>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientDirective> PatientDirective { get; set; } = new List<PatientDirective>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientDoctor> PatientDoctor { get; set; } = new List<PatientDoctor>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientHospital> PatientHospital { get; set; } = new List<PatientHospital>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientName> PatientName { get; set; } = new List<PatientName>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientNote> PatientNote { get; set; } = new List<PatientNote>();

    [InverseProperty("PatientSerNavigation")]
    public virtual PatientParticular? PatientParticular { get; set; }

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientPayor> PatientPayor { get; set; } = new List<PatientPayor>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientStaff> PatientStaff { get; set; } = new List<PatientStaff>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientTransportation> PatientTransportation { get; set; } = new List<PatientTransportation>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PatientVolume> PatientVolume { get; set; } = new List<PatientVolume>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Photo> Photo { get; set; } = new List<Photo>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<PointOfContact> PointOfContact { get; set; } = new List<PointOfContact>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<ScheduledActivity> ScheduledActivity { get; set; } = new List<ScheduledActivity>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Study> Study { get; set; } = new List<Study>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<Template> Template { get; set; } = new List<Template>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<TrackingInformation> TrackingInformation { get; set; } = new List<TrackingInformation>();

    [InverseProperty("PatientSerNavigation")]
    public virtual ICollection<TreatmentRecord> TreatmentRecord { get; set; } = new List<TreatmentRecord>();
}
