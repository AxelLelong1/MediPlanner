using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactPatientLabResult
{
    [Column("UOM")]
    public int? Uom { get; set; }

    public int? StatusType { get; set; }

    [StringLength(5)]
    public string? AbnormalFlagCode { get; set; }

    [StringLength(3)]
    public string? SymbolCode { get; set; }

    public int ComponentType { get; set; }

    [StringLength(20)]
    public string? TypeOfTest { get; set; }

    [StringLength(30)]
    public string? ComponentName { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? TestValue { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? MinNorm { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? MaxNorm { get; set; }

    [StringLength(1)]
    public string? TestValueStatusCode { get; set; }

    [StringLength(8)]
    public string TestValueStatusDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TestDateTime { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? MinReason { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? MaxReason { get; set; }

    [StringLength(1)]
    public string? TestResultApprovedIndicator { get; set; }

    [StringLength(20)]
    public string? ProducerStakeholderId { get; set; }

    [StringLength(61)]
    public string ProducerStakeholderName { get; set; } = null!;

    [StringLength(20)]
    public string? DspRefRange { get; set; }

    public int TestResultGroupId { get; set; }

    [Column("ctrpt_id")]
    [StringLength(20)]
    public string CtrptId { get; set; } = null!;

    public int TestId { get; set; }

    public int PatientVisitId { get; set; }

    public int TestResultId { get; set; }

    [Column("Facility_HospitalDepartmentID")]
    [StringLength(30)]
    public string? FacilityHospitalDepartmentId { get; set; }

    public int? FacilityId { get; set; }

    [StringLength(20)]
    public string? FacilityRequisitionId { get; set; }

    [StringLength(40)]
    public string? FacilityRequisitionDescription { get; set; }

    public int? TestPriority { get; set; }

    [StringLength(30)]
    public string? TestComponentFacilityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TestRequestedDateTime { get; set; }

    public int? TestRequestType { get; set; }

    public int? VerbalOrderId { get; set; }

    [StringLength(1)]
    public string? SentFlag { get; set; }

    [Column("UserId_Physician")]
    [StringLength(255)]
    public string? UserIdPhysician { get; set; }

    [Column("HospitalDepartmentId_Physician")]
    [StringLength(30)]
    public string? HospitalDepartmentIdPhysician { get; set; }

    [StringLength(1)]
    public string? SpecimenIndicator { get; set; }

    [StringLength(1)]
    public string? TestValidEntryIndicator { get; set; }

    [StringLength(1)]
    public string? OrderApprovedIndicator { get; set; }

    [StringLength(1)]
    public string? ResultApprovedIndicator { get; set; }

    [StringLength(1)]
    public string? CancelIndicator { get; set; }

    [StringLength(255)]
    public string? TestComment { get; set; }

    [StringLength(1)]
    public string? AlertIndicator { get; set; }

    [StringLength(255)]
    public string? ErroredReason { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? AbsoluteMaximum { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? AbsoluteMinimum { get; set; }

    [StringLength(1)]
    public string? TestResultIndicator { get; set; }

    [StringLength(255)]
    public string? TestResultValue { get; set; }

    [StringLength(255)]
    public string? TransLogUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransLogDateTime { get; set; }

    [StringLength(255)]
    public string? TransLogModifiedUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransLogModifiedDateTime { get; set; }

    [StringLength(1)]
    public string? TestResultValidEntryIndicator { get; set; }

    [StringLength(3000)]
    public string? TestResultComment { get; set; }

    [StringLength(30)]
    public string? FacilityGroupName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CollectionStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CollectionEndDate { get; set; }

    [StringLength(5)]
    public string? SpecimenAction { get; set; }

    [StringLength(20)]
    public string? CollectedBy { get; set; }

    [StringLength(20)]
    public string? DangerCode { get; set; }

    public string? ReleventClinicalInformation { get; set; }

    [Column(TypeName = "numeric(11, 4)")]
    public decimal? CollectionVolume { get; set; }

    [StringLength(5)]
    public string? CollectVolumecd { get; set; }

    [StringLength(255)]
    public string? TestResultGroupComment { get; set; }

    [StringLength(30)]
    public string? SpecimenSource { get; set; }

    [Column("PrimaryDX")]
    [StringLength(16)]
    public string? PrimaryDx { get; set; }

    [StringLength(5)]
    public string? SpecimentCondCode { get; set; }

    [StringLength(40)]
    public string? FacilityCategoryDescritpion { get; set; }

    [StringLength(255)]
    public string? TestOrderComment { get; set; }

    [Column("SpecimenRejectReasonCD")]
    [StringLength(5)]
    public string? SpecimenRejectReasonCd { get; set; }

    [StringLength(30)]
    public string? VitalIndicator { get; set; }
}
