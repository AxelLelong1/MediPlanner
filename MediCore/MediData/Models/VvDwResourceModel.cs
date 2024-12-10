using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwResourceModel
{
    [StringLength(112)]
    public string ResourceId { get; set; } = null!;

    [StringLength(30)]
    public string ResourceType { get; set; } = null!;

    [StringLength(64)]
    public string? ResourceFirstName { get; set; }

    [StringLength(64)]
    public string? ResourceLastName { get; set; }

    [StringLength(130)]
    public string? ResourceFullName { get; set; }

    [StringLength(208)]
    public string ResourceAliasName { get; set; } = null!;

    [StringLength(16)]
    public string? ResourceHonorific { get; set; }

    [StringLength(16)]
    public string? ResourceNameSuffix { get; set; }

    public int ResourceTypeNum { get; set; }

    [StringLength(255)]
    public string? ResourceUserId { get; set; }

    [StringLength(16)]
    public string ResourceObjectStatus { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? Schedulable { get; set; }

    [StringLength(4000)]
    public string? ResourceCompleteAddress { get; set; }

    public int? IsPrimaryResourceAddress { get; set; }

    [StringLength(64)]
    public string? ResourceAddressType { get; set; }

    [StringLength(254)]
    public string? ResourceAddressComment { get; set; }

    [StringLength(64)]
    public string? ResourcePrimaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? ResourceSecondaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? ResourcePagerNumber { get; set; }

    [StringLength(64)]
    public string? ResourceFaxNumber { get; set; }

    [Column("ResourceEMailAddress")]
    [StringLength(64)]
    public string? ResourceEmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResourceOriginationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResourceTerminationDate { get; set; }

    [StringLength(64)]
    public string? DoctorInstitution { get; set; }

    [StringLength(64)]
    public string? DoctorSpecialty { get; set; }

    [StringLength(64)]
    public string? ResourceProfession { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ResourceAdvancedPractitionerFlag { get; set; }

    [StringLength(254)]
    public string? ResourceComment { get; set; }

    [StringLength(64)]
    public string? DefaultDepartmentName { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AssignedToDepartment { get; set; }

    [StringLength(16)]
    public string? DepartmentId { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(254)]
    public string? DepartmentComment { get; set; }

    [StringLength(32)]
    public string? AccessRights { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepartmentHstryDateTime { get; set; }

    [StringLength(255)]
    public string? DepartmentHstryUserName { get; set; }

    [StringLength(64)]
    public string? HospitalName { get; set; }

    [StringLength(64)]
    public string? HospitalLocation { get; set; }

    [StringLength(4000)]
    public string? HospitalCompleteAddress { get; set; }

    [StringLength(64)]
    public string? HospitalWebAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HospitalHstryDateTime { get; set; }

    [StringLength(255)]
    public string? HospitalHstryUserName { get; set; }

    [Column("ctrHospitalSer")]
    public long? CtrHospitalSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }
}
