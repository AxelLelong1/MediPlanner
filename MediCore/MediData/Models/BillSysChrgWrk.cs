using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("VarisBillRunSeqId", "ActInstProcCodeSer", "ActInstProcCodeRevCount", "ChargeIndicator")]
[Index("PatientSer", Name = "XIF767BillSysChrgWrk")]
[Index("DepartmentSer", Name = "XIF768BillSysChrgWrk")]
[Index("HospitalSer", Name = "XIF769BillSysChrgWrk")]
[Index("ActivitySerialNumber", Name = "XIF770BillSysChrgWrk")]
[Index("ChargesControlSerialNumber", Name = "XIF771BillSysChrgWrk")]
[Index("AccountBillingCodeSer", Name = "XIF772BillSysChrgWrk")]
[Index("ProcedureCodeSer", Name = "XIF773BillSysChrgWrk")]
[Index("ActivityCaptureSer", Name = "XIF774BillSysChrgWrk")]
public partial class BillSysChrgWrk
{
    [Key]
    public int VarisBillRunSeqId { get; set; }

    [Key]
    public long ActInstProcCodeSer { get; set; }

    [Key]
    public int ActInstProcCodeRevCount { get; set; }

    [Key]
    [StringLength(16)]
    public string ChargeIndicator { get; set; } = null!;

    [StringLength(64)]
    public string BillSysInstId { get; set; } = null!;

    [StringLength(64)]
    public string BillSysId { get; set; } = null!;

    public long? PatientSer { get; set; }

    [StringLength(64)]
    public string? PatientLastName { get; set; }

    [StringLength(64)]
    public string? PatientFirstName { get; set; }

    [StringLength(64)]
    public string? PatientMiddleName { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [StringLength(32)]
    public string? PatientAccountNumberId { get; set; }

    [StringLength(64)]
    public string? PatientAddressType { get; set; }

    [StringLength(64)]
    public string? PatientCountry { get; set; }

    [StringLength(64)]
    public string? PatientStateOrProvince { get; set; }

    [StringLength(64)]
    public string? PatientCounty { get; set; }

    [StringLength(64)]
    public string? PatientCityOrTownship { get; set; }

    [StringLength(64)]
    public string? PatientAddressLine1 { get; set; }

    [StringLength(64)]
    public string? PatientAddressLine2 { get; set; }

    [StringLength(16)]
    public string? PatientPostalCode { get; set; }

    [StringLength(64)]
    public string? PhoneNumberHome1 { get; set; }

    [StringLength(64)]
    public string? PhoneNumberHome2 { get; set; }

    [StringLength(64)]
    public string? PhoneNumberHome3 { get; set; }

    [StringLength(64)]
    public string? PhoneNumberBusiness1 { get; set; }

    [StringLength(64)]
    public string? PhoneNumberBusiness2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientBirthDate { get; set; }

    [Column("PatientSSN")]
    [StringLength(64)]
    public string? PatientSsn { get; set; }

    [StringLength(64)]
    public string? PatientRace { get; set; }

    [StringLength(64)]
    public string? PatientMothersMaidenName { get; set; }

    [StringLength(16)]
    public string? PatientSex { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    [StringLength(16)]
    public string? PatientMaritalStatus { get; set; }

    [StringLength(16)]
    public string? PatientLocation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientDischargeDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientAdmissionDate { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    public long? HospitalSer { get; set; }

    [StringLength(64)]
    public string? HospitalName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDateOfService { get; set; }

    [StringLength(32)]
    public string? CodeType { get; set; }

    [StringLength(32)]
    public string? ActivityType { get; set; }

    [StringLength(64)]
    public string? BillingCode { get; set; }

    public int? MedicareComplexCode { get; set; }

    [StringLength(64)]
    public string? ProcedureCode { get; set; }

    [StringLength(64)]
    public string? ModifierCode { get; set; }

    [StringLength(64)]
    public string? UserDefinedCode { get; set; }

    [StringLength(254)]
    public string? ProcedureComment { get; set; }

    [StringLength(64)]
    public string? ProcedureShortComment { get; set; }

    [StringLength(64)]
    public string? ModifierDescription { get; set; }

    [StringLength(64)]
    public string? ModifierCode2 { get; set; }

    [StringLength(64)]
    public string? ModifierDescription2 { get; set; }

    [StringLength(64)]
    public string? ModifierCode3 { get; set; }

    [StringLength(64)]
    public string? ModifierDescription3 { get; set; }

    [StringLength(64)]
    public string? ModifierCode4 { get; set; }

    [StringLength(64)]
    public string? ModifierDescription4 { get; set; }

    [StringLength(64)]
    public string? ModifierCode5 { get; set; }

    [StringLength(64)]
    public string? ModifierDescription5 { get; set; }

    [StringLength(64)]
    public string? ModifierCode6 { get; set; }

    [StringLength(64)]
    public string? ModifierDescription6 { get; set; }

    [StringLength(64)]
    public string? ModifierCode7 { get; set; }

    [StringLength(64)]
    public string? ModifierDescription7 { get; set; }

    [Column("TSAComment")]
    [StringLength(254)]
    public string? Tsacomment { get; set; }

    public int? NoChargeFlag { get; set; }

    public int? NumberOfCycles { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrmrTechCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrmrProfessCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrmrGlblCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OtherGlobalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OtherProfessionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OtherTechnicalCharge { get; set; }

    [Column("TechnicalRVU")]
    public double? TechnicalRvu { get; set; }

    [Column("ProfessionalRVU")]
    public double? ProfessionalRvu { get; set; }

    [Column("GlobalRVU")]
    public double? GlobalRvu { get; set; }

    [Column(TypeName = "money")]
    public decimal? AverageActivityCost { get; set; }

    [Column("BillingServiceID")]
    [StringLength(16)]
    public string? BillingServiceId { get; set; }

    [Column("RVUExportCode")]
    public int? RvuexportCode { get; set; }

    [Column("RVUExport")]
    public int? Rvuexport { get; set; }

    [Column("RVUMultiplier")]
    public double? Rvumultiplier { get; set; }

    [StringLength(32)]
    public string? ExportType { get; set; }

    public int? ExternalBillingCodeExport { get; set; }

    [StringLength(255)]
    public string? ApprovedBy { get; set; }

    [StringLength(255)]
    public string? CompletedBy { get; set; }

    [StringLength(16)]
    public string? DiagnosisCode { get; set; }

    [StringLength(254)]
    public string? DiagnosisDescription { get; set; }

    [StringLength(64)]
    public string? InsuranceCompanyName1 { get; set; }

    [StringLength(32)]
    public string? InsurancePlanType1 { get; set; }

    [StringLength(16)]
    public string? InsurancePlanNumber1 { get; set; }

    [StringLength(254)]
    public string? AuthorizationDescription1 { get; set; }

    [StringLength(64)]
    public string? InsuranceCompanyName2 { get; set; }

    [StringLength(32)]
    public string? InsurancePlanType2 { get; set; }

    [StringLength(16)]
    public string? InsurancePlanNumber2 { get; set; }

    [StringLength(254)]
    public string? AuthorizationDescription2 { get; set; }

    [StringLength(64)]
    public string? InsuranceCompanyName3 { get; set; }

    [StringLength(32)]
    public string? InsurancePlanType3 { get; set; }

    [StringLength(16)]
    public string? InsurancePlanNumber3 { get; set; }

    [StringLength(254)]
    public string? AuthorizationDescription3 { get; set; }

    [StringLength(64)]
    public string? InsuranceCompanyName4 { get; set; }

    [StringLength(32)]
    public string? InsurancePlanType4 { get; set; }

    [StringLength(16)]
    public string? InsurancePlanNumber4 { get; set; }

    [StringLength(254)]
    public string? AuthorizationDescription4 { get; set; }

    [StringLength(64)]
    public string? RadiationOncologistLastName { get; set; }

    [StringLength(64)]
    public string? RadiationOncologistFirstName { get; set; }

    [Column("RadiationOncologistID")]
    [StringLength(16)]
    public string? RadiationOncologistId { get; set; }

    [StringLength(64)]
    public string? RadiationOncologistSpecialty { get; set; }

    [StringLength(64)]
    public string? ReferringPhysicianLastName { get; set; }

    [StringLength(64)]
    public string? ReferringPhysicianFirstName { get; set; }

    [Column("ReferringPhysicianID")]
    [StringLength(16)]
    public string? ReferringPhysicianId { get; set; }

    [StringLength(64)]
    public string? ReferringPhysicianSpecialty { get; set; }

    public long? ActivitySerialNumber { get; set; }

    public long? ChargesControlSerialNumber { get; set; }

    public long? AccountBillingCodeSer { get; set; }

    public int? AccountBillingCodeRevCount { get; set; }

    public long? ProcedureCodeSer { get; set; }

    public int? ProcedureCodeRevCount { get; set; }

    public int? InPatientFlag { get; set; }

    public long? ActivityCaptureSer { get; set; }

    public int? ActivityCaptureRevCount { get; set; }

    [StringLength(16)]
    public string? TransId { get; set; }

    [StringLength(16)]
    public string? BatchId { get; set; }

    [StringLength(16)]
    public string? FillerRefNo { get; set; }

    [StringLength(255)]
    public string? ExportedBy { get; set; }

    [ForeignKey("AccountBillingCodeSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual AccountBillingCode? AccountBillingCodeSerNavigation { get; set; }

    [ForeignKey("ActInstProcCodeSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual ActInstProcCode ActInstProcCodeSerNavigation { get; set; } = null!;

    [ForeignKey("ActivityCaptureSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual ActivityCapture? ActivityCaptureSerNavigation { get; set; }

    [ForeignKey("ActivitySerialNumber")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual Activity? ActivitySerialNumberNavigation { get; set; }

    [ForeignKey("ChargesControlSerialNumber")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual ChargesControl? ChargesControlSerialNumberNavigation { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("HospitalSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual Hospital? HospitalSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual Patient? PatientSerNavigation { get; set; }

    [ForeignKey("ProcedureCodeSer")]
    [InverseProperty("BillSysChrgWrk")]
    public virtual ProcedureCode? ProcedureCodeSerNavigation { get; set; }
}
