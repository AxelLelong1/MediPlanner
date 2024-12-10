using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientModelEnm
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(1)]
    public string PatientId2 { get; set; } = null!;

    [StringLength(30)]
    public string PatientFirstName { get; set; } = null!;

    [StringLength(30)]
    public string? PatientMiddleName { get; set; }

    [StringLength(30)]
    public string? PatientLastName { get; set; }

    [StringLength(62)]
    public string? PatientFullName { get; set; }

    [StringLength(1)]
    public string PatientHonorific { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PatientDateOfBirth { get; set; }

    [StringLength(44)]
    public string? PatientCitizenShip { get; set; }

    [StringLength(1)]
    public string PatientType { get; set; } = null!;

    [StringLength(64)]
    public string? PatientRace { get; set; }

    [StringLength(40)]
    public string? PatientSex { get; set; }

    [Column("PatientSSN")]
    [StringLength(20)]
    public string? PatientSsn { get; set; }

    [StringLength(1)]
    public string UniversalPatientId { get; set; } = null!;

    [StringLength(64)]
    public string? PatientLanguage { get; set; }

    [StringLength(1)]
    public string? PatientMaritalStatus { get; set; }

    [StringLength(30)]
    public string? PatientOccupation { get; set; }

    [StringLength(30)]
    public string? PatientPresentEmployerName { get; set; }

    [StringLength(30)]
    public string? MotherName { get; set; }

    [StringLength(30)]
    public string? FatherName { get; set; }

    [StringLength(64)]
    public string? Ethnicity { get; set; }

    [StringLength(50)]
    public string? Religion { get; set; }

    [StringLength(30)]
    public string? MotherMaidenName { get; set; }

    [StringLength(1)]
    public string? HealthCaredpoa { get; set; }

    [StringLength(1)]
    public string? DoNotResuscitate { get; set; }

    [StringLength(1)]
    public string? DoNotHospitalize { get; set; }

    [StringLength(1)]
    public string? HasLivingWill { get; set; }

    [StringLength(1)]
    public string? IsAutopsyRequested { get; set; }

    [StringLength(1)]
    public string? FeedingRestrictions { get; set; }

    [StringLength(1)]
    public string? IsOrganDonor { get; set; }

    [StringLength(30)]
    public string? BirthPlace { get; set; }

    [StringLength(1)]
    public string? MedicationRestrictions { get; set; }

    [StringLength(1)]
    public string? TreatmentRestrictions { get; set; }

    [StringLength(30)]
    public string? PatientAddressLine1 { get; set; }

    [StringLength(30)]
    public string? PatientAddressLine2 { get; set; }

    [StringLength(30)]
    public string? PatientCity { get; set; }

    [StringLength(44)]
    public string? PatientCountry { get; set; }

    [StringLength(30)]
    public string? PatientCounty { get; set; }

    [StringLength(10)]
    public string? PostalCode { get; set; }

    [StringLength(30)]
    public string? State { get; set; }

    [StringLength(186)]
    public string? PatientFullAddress { get; set; }

    [StringLength(1)]
    public string PatientAddressComment { get; set; } = null!;

    [StringLength(28)]
    public string? PatientHomePhone { get; set; }

    [StringLength(28)]
    public string? PatientWorkPhone { get; set; }

    [StringLength(28)]
    public string? PatientMobilePhone { get; set; }

    [StringLength(28)]
    public string? PatientPagerNumber { get; set; }

    [Column("PatientEMailAddress")]
    [StringLength(255)]
    public string? PatientEmailAddress { get; set; }

    [StringLength(144)]
    public string PatientLocation { get; set; } = null!;

    [StringLength(1)]
    public string PatientStatus { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string PatientInOutStatus { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string PatientDeathStatus { get; set; } = null!;

    [StringLength(1)]
    public string PatientDeathCause { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PatientDeathDate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ClinicalTrial { get; set; } = null!;

    [StringLength(1)]
    public string PatientComment { get; set; } = null!;

    [StringLength(1)]
    public string PatientNotes { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PatientCreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [StringLength(50)]
    public string? HospitalName { get; set; }

    [StringLength(1)]
    public string PatientRoomNumber { get; set; } = null!;

    public int? PatientAdmissionDate { get; set; }

    public int? PatientDischargeDate { get; set; }

    [StringLength(30)]
    public string? HospitalAddress { get; set; }

    [StringLength(1)]
    public string DepartmentComment { get; set; } = null!;

    [StringLength(1)]
    public string DepartmentId { get; set; } = null!;

    [StringLength(1)]
    public string DepartmentName { get; set; } = null!;

    [Column("ctrDepartmentSer")]
    public int? CtrDepartmentSer { get; set; }

    [StringLength(16)]
    public string? PatientDiagnosisCode { get; set; }

    [StringLength(1)]
    public string PatientDiagnosisDescription { get; set; } = null!;

    [StringLength(1)]
    public string PatientDiagnosisCodeType { get; set; } = null!;

    [StringLength(186)]
    public string? PatientEmergencyContactAddress { get; set; }

    [StringLength(1)]
    public string PatientEmergencyContactComment { get; set; } = null!;

    public int PatientEmergencyContactEntrusted { get; set; }

    [StringLength(50)]
    public string? PatientEmergencyContactFullName { get; set; }

    [StringLength(28)]
    public string? PatientEmergencyContactHomePhone { get; set; }

    [StringLength(28)]
    public string? PatientEmergencyContactMobilePhone { get; set; }

    [StringLength(28)]
    public string? PatientEmergencyContactWorkPhone { get; set; }

    [StringLength(40)]
    public string? PatientEmergencyContactRelationship { get; set; }

    [StringLength(1)]
    public string OncologistFirstName { get; set; } = null!;

    [StringLength(1)]
    public string OncologistFullName { get; set; } = null!;

    [StringLength(1)]
    public string OncologistHonorific { get; set; } = null!;

    [StringLength(1)]
    public string OncologistLastName { get; set; } = null!;

    [StringLength(1)]
    public string OncologistNameSuffix { get; set; } = null!;

    [StringLength(1)]
    public string OncologistSpecialty { get; set; } = null!;

    [StringLength(1)]
    public string PayorInsuredName { get; set; } = null!;

    [StringLength(1)]
    public string PayorAddress { get; set; } = null!;

    [StringLength(1)]
    public string PayorAuthorizationId { get; set; } = null!;

    [StringLength(1)]
    public string PayorComment { get; set; } = null!;

    [StringLength(1)]
    public string PayorCompanyName { get; set; } = null!;

    [StringLength(1)]
    public string PayorPhone { get; set; } = null!;

    public int? PayorPlanExpiraryDate { get; set; }

    [StringLength(1)]
    public string PayorPlanNumber { get; set; } = null!;

    public int? PayorPlanType { get; set; }

    public int? PayorPolicyNumber { get; set; }

    public int? PayorRelationshipwithInsured { get; set; }

    public int? PayorCurrentAccountNumber { get; set; }

    [Column("ctrPayorSer")]
    public int CtrPayorSer { get; set; }

    [Column("ctrPlanTypeSer")]
    public int CtrPlanTypeSer { get; set; }

    public int? ReferringPhysicianFirstName { get; set; }

    public int? ReferringPhysicianFullName { get; set; }

    public int? ReferringPhysicianHonorific { get; set; }

    public int? ReferringPhysicianLastName { get; set; }

    public int? ReferringPhysicianNameSuffix { get; set; }

    public int? ReferringPhysicianSpecialty { get; set; }

    [StringLength(1)]
    public string TransportationName { get; set; } = null!;

    [StringLength(1)]
    public string TransportationPhone { get; set; } = null!;

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrHospitalSer")]
    public int CtrHospitalSer { get; set; }

    [Column("ctrPrimaryOncologistSer")]
    public int CtrPrimaryOncologistSer { get; set; }

    [Column("ctrPrimaryReferringPhysicianSer")]
    public int CtrPrimaryReferringPhysicianSer { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string? CtrptId { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctrprovider_stkh_id_PrimaryOncologist")]
    [StringLength(20)]
    public string? CtrproviderStkhIdPrimaryOncologist { get; set; }

    [Column("ctrprovider_stkh_id_RefPhysician")]
    [StringLength(20)]
    public string? CtrproviderStkhIdRefPhysician { get; set; }

    [Column("IsMOTestPatient")]
    public bool? IsMotestPatient { get; set; }
}
