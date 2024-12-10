using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwActivityBillingModelIncr
{
    [StringLength(64)]
    public string? ProcedureCode { get; set; }

    [StringLength(32)]
    public string? ProcedureCodeType { get; set; }

    [StringLength(254)]
    public string? ProcedureCodeDescription { get; set; }

    [StringLength(64)]
    public string? Description { get; set; }

    [StringLength(64)]
    public string? ProcedureBillingCode { get; set; }

    [StringLength(32)]
    public string? ActivityType { get; set; }

    [StringLength(64)]
    public string? ActivityCategory { get; set; }

    [Column(TypeName = "money")]
    public decimal? ActivityCost { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOn { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrimaryGlobalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrimaryTechnicalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrimaryProfessionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OtherProfessionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OtherTechnicalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OtherGlobalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? ChargeForecast { get; set; }

    [Column(TypeName = "money")]
    public decimal? ActualCharge { get; set; }

    [Column("ProfessionalRVU")]
    public double? ProfessionalRvu { get; set; }

    [Column("GlobalRVU")]
    public double? GlobalRvu { get; set; }

    [Column("TechnicalRVU")]
    public double? TechnicalRvu { get; set; }

    public double? WorkUnit { get; set; }

    public int? Complexity { get; set; }

    public int? Exportable { get; set; }

    [StringLength(196)]
    public string? AttendingOncologistName { get; set; }

    [StringLength(130)]
    public string? OncologistName { get; set; }

    [StringLength(16)]
    public string? OncologistId { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ActivityExportedFlag { get; set; } = null!;

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(64)]
    public string? HospitalName { get; set; }

    [StringLength(20)]
    public string? AccountBillingCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AccountBillingCodeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AccountBillingCodeEndDate { get; set; }

    [StringLength(16)]
    public string? AccountBillingCodeObjectStatus { get; set; }

    [StringLength(1)]
    public string? AccountBillingCodeValidEntryInd { get; set; }

    public int? AccountBillingCodeInPatientFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDateOfService { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDateOfService { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExportedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MarkedCompletedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreditExportedDateTime { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? InPatientFlag { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    [StringLength(255)]
    public string? MarkedCompletedBy { get; set; }

    [StringLength(255)]
    public string? ExportedBy { get; set; }

    [StringLength(255)]
    public string? ChargeWaivedBy { get; set; }

    [StringLength(255)]
    public string? ReviewedBy { get; set; }

    [StringLength(255)]
    public string? CreditedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreditedDateTime { get; set; }

    [StringLength(254)]
    public string? CreditNote { get; set; }

    [StringLength(459)]
    public string? AllModifierCodes { get; set; }

    [Column(TypeName = "money")]
    public decimal? CreditAmount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsScheduled { get; set; }

    public string? DiagnosisId { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(130)]
    public string? PatientFullName { get; set; }

    [StringLength(16)]
    public string? ObjectStatus { get; set; }

    [Column("ActivityInstance_ObjectStatus")]
    [StringLength(16)]
    public string? ActivityInstanceObjectStatus { get; set; }

    [Column("ActInstProcCode_ObjectStatus")]
    [StringLength(16)]
    public string? ActInstProcCodeObjectStatus { get; set; }

    public int? ActivityCaptureRevCount { get; set; }

    public int? ActivityInstanceRevCount { get; set; }

    public int? ActivityCodeMdRevCount { get; set; }

    public int? ProcedureCodeRevCount { get; set; }

    public int? AccountBillingCodeRevCount { get; set; }

    public int? ActInstProcCodeRevCount { get; set; }

    public int? CreditRevCount { get; set; }

    [Column("TemplateID")]
    [StringLength(64)]
    public string? TemplateId { get; set; }

    public int? TemplateRevCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TemplateCreationDate { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [Column("ctrActivityInstanceSer")]
    public long? CtrActivityInstanceSer { get; set; }

    [Column("ctrAttendingOncologistSer")]
    public long? CtrAttendingOncologistSer { get; set; }

    [Column("ctrTemplateSer")]
    public long? CtrTemplateSer { get; set; }

    [Column("ctrTemplateCycleSer")]
    public long? CtrTemplateCycleSer { get; set; }

    [Column("ctrActivityCaptureSer")]
    public long? CtrActivityCaptureSer { get; set; }

    [Column("ctrCourseSer")]
    public long? CtrCourseSer { get; set; }

    [Column("ctrActInstProcCodeSer")]
    public long? CtrActInstProcCodeSer { get; set; }

    [Column("ctrProcedureCodeSer")]
    public long? CtrProcedureCodeSer { get; set; }

    [Column("ctrResourceSer")]
    public long? CtrResourceSer { get; set; }

    [Column("ctrAccountBillingCodeSer")]
    public long? CtrAccountBillingCodeSer { get; set; }

    [Column("ctrCreditSer")]
    public long? CtrCreditSer { get; set; }

    [Column("ctrModifierSer")]
    public long? CtrModifierSer { get; set; }

    [Column("ctrDiagnosisSer")]
    public string? CtrDiagnosisSer { get; set; }

    [Column("ctrResourceSer_Activity")]
    public long? CtrResourceSerActivity { get; set; }

    [Column("ctrActivityCategorySer")]
    public long? CtrActivityCategorySer { get; set; }

    [Column("ctrScheduledActivitySer")]
    public long? CtrScheduledActivitySer { get; set; }

    [Column("ctrAttendeeSer")]
    public long? CtrAttendeeSer { get; set; }

    [StringLength(255)]
    public string? CompletedBy { get; set; }

    public long? PayorSer { get; set; }
}
