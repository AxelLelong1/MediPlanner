﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimStaffEnm
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
    public string? StaffFirstName { get; set; }

    [StringLength(30)]
    public string? StaffLastName { get; set; }

    [StringLength(61)]
    public string? StaffFullName { get; set; }

    [StringLength(80)]
    public string? StaffAliasName { get; set; }

    [Column("designation_txt")]
    [StringLength(255)]
    public string? DesignationTxt { get; set; }

    [StringLength(199)]
    public string? StaffCompleteAddress { get; set; }

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
    public string? StaffAddressType { get; set; }

    [StringLength(28)]
    public string? StaffPrimaryPhoneNumber { get; set; }

    [StringLength(28)]
    public string? StaffSecondaryPhoneNumber { get; set; }

    [StringLength(28)]
    public string? StaffFaxNumber { get; set; }

    [StringLength(28)]
    public string? StaffPagerNumber { get; set; }

    [StringLength(40)]
    public string? TypeOfEmail { get; set; }

    [Column("StaffEMailAddress")]
    [StringLength(255)]
    public string? StaffEmailAddress { get; set; }

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
