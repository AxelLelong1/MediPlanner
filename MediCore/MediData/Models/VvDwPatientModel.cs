using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientModel
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [StringLength(64)]
    public string? PatientFirstName { get; set; }

    [StringLength(64)]
    public string? PatientMiddleName { get; set; }

    [StringLength(64)]
    public string PatientLastName { get; set; } = null!;

    [StringLength(130)]
    public string PatientFullName { get; set; } = null!;

    [StringLength(16)]
    public string? PatientHonorific { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientDateOfBirth { get; set; }

    [StringLength(64)]
    public string? PatientCitizenShip { get; set; }

    [StringLength(30)]
    public string? PatientType { get; set; }

    [StringLength(64)]
    public string? PatientRace { get; set; }

    [StringLength(16)]
    public string? PatientSex { get; set; }

    [Column("PatientSSN")]
    [StringLength(64)]
    public string? PatientSsn { get; set; }

    [StringLength(32)]
    public string? UniversalPatientId { get; set; }

    [StringLength(64)]
    public string? PatientLanguage { get; set; }

    [StringLength(64)]
    public string? PatientAddressLine1 { get; set; }

    [StringLength(64)]
    public string? PatientAddressLine2 { get; set; }

    [StringLength(64)]
    public string? PatientCity { get; set; }

    [StringLength(64)]
    public string? PatientCountry { get; set; }

    [StringLength(64)]
    public string? PatientCounty { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [StringLength(64)]
    public string? State { get; set; }

    [StringLength(348)]
    public string? PatientFullAddress { get; set; }

    [StringLength(254)]
    public string? PatientAddressComment { get; set; }

    [StringLength(64)]
    public string? PatientHomePhone { get; set; }

    [StringLength(64)]
    public string? PatientWorkPhone { get; set; }

    [StringLength(64)]
    public string? PatientMobilePhone { get; set; }

    [StringLength(64)]
    public string? PatientPagerNumber { get; set; }

    [Column("PatientEMailAddress")]
    [StringLength(64)]
    public string? PatientEmailAddress { get; set; }

    [StringLength(16)]
    public string? PatientLocation { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string PatientInOutStatus { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string PatientDeathStatus { get; set; } = null!;

    [StringLength(254)]
    public string? PatientDeathCause { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientDeathDate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ClinicalTrial { get; set; } = null!;

    [StringLength(254)]
    public string? PatientComment { get; set; }

    [StringLength(1024)]
    public string? PatientNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PatientCreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [StringLength(64)]
    public string? HospitalName { get; set; }

    [StringLength(16)]
    public string? PatientRoomNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientAdmissionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientDischargeDate { get; set; }

    [StringLength(478)]
    public string? HospitalAddress { get; set; }

    [StringLength(254)]
    public string? DepartmentComment { get; set; }

    [StringLength(16)]
    public string? DepartmentId { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [StringLength(254)]
    public string? PatientDiagnosisCode { get; set; }

    [StringLength(254)]
    public string? PatientDiagnosisDescription { get; set; }

    [StringLength(254)]
    public string? PatientDiagnosisCodeType { get; set; }

    [StringLength(1024)]
    public string? PatientEmergencyContactAddress { get; set; }

    [StringLength(254)]
    public string? PatientEmergencyContactComment { get; set; }

    public int? PatientEmergencyContactEntrusted { get; set; }

    [StringLength(512)]
    public string? PatientEmergencyContactFullName { get; set; }

    [StringLength(64)]
    public string? PatientEmergencyContactHomePhone { get; set; }

    [StringLength(64)]
    public string? PatientEmergencyContactMobilePhone { get; set; }

    [StringLength(64)]
    public string? PatientEmergencyContactWorkPhone { get; set; }

    [StringLength(64)]
    public string? PatientEmergencyContactRelationship { get; set; }

    [StringLength(64)]
    public string? OncologistFirstName { get; set; }

    [StringLength(512)]
    public string? OncologistFullName { get; set; }

    [StringLength(16)]
    public string? OncologistHonorific { get; set; }

    [StringLength(64)]
    public string? OncologistLastName { get; set; }

    [StringLength(16)]
    public string? OncologistNameSuffix { get; set; }

    [StringLength(64)]
    public string? OncologistSpecialty { get; set; }

    [StringLength(64)]
    public string? PayorInsuredName { get; set; }

    [StringLength(348)]
    public string? PayorAddress { get; set; }

    [StringLength(16)]
    public string? PayorAuthorizationId { get; set; }

    [StringLength(254)]
    public string? PayorComment { get; set; }

    [StringLength(64)]
    public string? PayorCompanyName { get; set; }

    [StringLength(64)]
    public string? PayorPhone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayorPlanExpiraryDate { get; set; }

    [StringLength(16)]
    public string? PayorPlanNumber { get; set; }

    [StringLength(32)]
    public string? PayorPlanType { get; set; }

    [StringLength(16)]
    public string? PayorPolicyNumber { get; set; }

    [StringLength(64)]
    public string? PayorRelationshipwithInsured { get; set; }

    [StringLength(32)]
    public string? PayorCurrentAccountNumber { get; set; }

    [Column("ctrPayorSer")]
    public long? CtrPayorSer { get; set; }

    [Column("ctrPlanTypeSer")]
    public long? CtrPlanTypeSer { get; set; }

    [StringLength(64)]
    public string? ReferringPhysicianFirstName { get; set; }

    [StringLength(512)]
    public string? ReferringPhysicianFullName { get; set; }

    [StringLength(16)]
    public string? ReferringPhysicianHonorific { get; set; }

    [StringLength(64)]
    public string? ReferringPhysicianLastName { get; set; }

    [StringLength(16)]
    public string? ReferringPhysicianNameSuffix { get; set; }

    [StringLength(64)]
    public string? ReferringPhysicianSpecialty { get; set; }

    [StringLength(64)]
    public string? TransportationName { get; set; }

    [StringLength(64)]
    public string? TransportationPhone { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrHospitalSer")]
    public long? CtrHospitalSer { get; set; }

    [Column("ctrPrimaryOncologistSer")]
    public long? CtrPrimaryOncologistSer { get; set; }

    [Column("ctrPrimaryReferringPhysicianSer")]
    public long? CtrPrimaryReferringPhysicianSer { get; set; }

    [Column("IsMOTestPatient")]
    public int IsMotestPatient { get; set; }
}
