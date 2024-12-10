using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimDoctorEnm
{
    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("stkh_name_id")]
    public int StkhNameId { get; set; }

    [Column("name_cd")]
    [StringLength(1)]
    public string NameCd { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

    [StringLength(30)]
    public string? DoctorFirstName { get; set; }

    [StringLength(30)]
    public string? DoctorLastName { get; set; }

    [StringLength(61)]
    public string? DoctorFullName { get; set; }

    [StringLength(80)]
    public string? DoctorAliasName { get; set; }

    [Column("designation_txt")]
    [StringLength(255)]
    public string? DesignationTxt { get; set; }

    [StringLength(289)]
    public string? DoctorCompleteAddress { get; set; }

    [StringLength(44)]
    public string? Country { get; set; }

    [Column("city")]
    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(30)]
    public string? State { get; set; }

    [StringLength(10)]
    public string? PostalCode { get; set; }

    [StringLength(40)]
    public string? DoctorAddressType { get; set; }

    [StringLength(28)]
    public string? DoctorPrimaryPhoneNumber { get; set; }

    [StringLength(28)]
    public string? DoctorSecondaryPhoneNumber { get; set; }

    [StringLength(28)]
    public string? DoctorFaxNumber { get; set; }

    [StringLength(28)]
    public string? DoctorPagerNumber { get; set; }

    [StringLength(40)]
    public string? TypeOfEmail { get; set; }

    [Column("DoctorEMailAddress")]
    [StringLength(64)]
    public string? DoctorEmailAddress { get; set; }

    [Column("pref_ind")]
    [StringLength(1)]
    public string? PrefInd { get; set; }

    [Column("role_desc")]
    [StringLength(40)]
    public string? RoleDesc { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("prof_desc")]
    [StringLength(40)]
    public string ProfDesc { get; set; } = null!;

    public long? ResourceSer { get; set; }
}
