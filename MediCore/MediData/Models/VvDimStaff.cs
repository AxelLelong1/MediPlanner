using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimStaff
{
    [StringLength(64)]
    public string? StaffFirstName { get; set; }

    [StringLength(64)]
    public string? StaffLastName { get; set; }

    [StringLength(130)]
    public string? StaffFullName { get; set; }

    [StringLength(80)]
    public string? StaffAliasName { get; set; }

    [StringLength(16)]
    public string? StaffHonorific { get; set; }

    [StringLength(16)]
    public string? StaffNameSuffix { get; set; }

    [StringLength(16)]
    public string? StaffId { get; set; }

    public int? ResourceTypeNum { get; set; }

    [StringLength(16)]
    public string StaffObjectStatus { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? Schedulable { get; set; }

    [StringLength(4000)]
    public string? StaffCompleteAddress { get; set; }

    public int? IsPrimaryResourceAddress { get; set; }

    [StringLength(64)]
    public string? StaffAddressType { get; set; }

    [StringLength(254)]
    public string? StaffAddressComment { get; set; }

    [StringLength(64)]
    public string? StaffPrimaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? StaffSecondaryPhoneNumber { get; set; }

    [StringLength(64)]
    public string? StaffPagerNumber { get; set; }

    [StringLength(64)]
    public string? StaffFaxNumber { get; set; }

    [Column("StaffEMailAddress")]
    [StringLength(255)]
    public string? StaffEmailAddress { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StaffOriginationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StaffTerminationDate { get; set; }

    [StringLength(64)]
    public string? StaffProfession { get; set; }

    [StringLength(254)]
    public string? StaffComment { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? StaffAdvancedPractitionerFlag { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [Column("ctrstkh_id")]
    [StringLength(20)]
    public string? CtrstkhId { get; set; }
}
