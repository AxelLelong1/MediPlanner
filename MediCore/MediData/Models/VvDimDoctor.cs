using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimDoctor
{
    [StringLength(64)]
    public string? DoctorFirstName { get; set; }

    [StringLength(64)]
    public string? DoctorLastName { get; set; }

    [StringLength(130)]
    public string? DoctorFullName { get; set; }

    [StringLength(80)]
    public string? DoctorAliasName { get; set; }

    [StringLength(16)]
    public string? DoctorHonorific { get; set; }

    [StringLength(16)]
    public string? DoctorNameSuffix { get; set; }

    [StringLength(64)]
    public string? DoctorSpecialty { get; set; }

    [StringLength(16)]
    public string? DoctorId { get; set; }

    [StringLength(30)]
    public string? ResourceType { get; set; }

    public int? ResourceTypeNum { get; set; }

    [StringLength(16)]
    public string ResourceObjectStatus { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? Schedulable { get; set; }

    [StringLength(4000)]
    public string? DoctorCompleteAddress { get; set; }

    public int? IsPrimaryDoctorAddress { get; set; }

    [StringLength(64)]
    public string? DoctorAddressType { get; set; }

    [StringLength(254)]
    public string? DoctorAddressComment { get; set; }

    [StringLength(64)]
    public string? DoctorPrimaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? DoctorSecondaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? DoctorPagerNumber { get; set; }

    [StringLength(64)]
    public string? DoctorFaxNumber { get; set; }

    [Column("DoctorEMailAddress")]
    [StringLength(64)]
    public string? DoctorEmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DoctorOriginationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DoctorTerminationDate { get; set; }

    [StringLength(64)]
    public string? DoctorInstitution { get; set; }

    [StringLength(254)]
    public string? DoctorComment { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [StringLength(64)]
    public string? Country { get; set; }

    [StringLength(64)]
    public string? State { get; set; }

    [StringLength(64)]
    public string? City { get; set; }

    [StringLength(64)]
    public string? County { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [Column("ctrstkh_id")]
    [StringLength(20)]
    public string? CtrstkhId { get; set; }
}
