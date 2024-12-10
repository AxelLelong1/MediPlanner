using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetPatientPrimaryReferringPhysicianDetails
{
    public long? RankNumber { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string? Honorific { get; set; }

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    [Column("Primary Referring Physician Full Name")]
    [StringLength(130)]
    public string? PrimaryReferringPhysicianFullName { get; set; }

    [Column("Primary ReferringPhycian Speciality")]
    [StringLength(64)]
    public string? PrimaryReferringPhycianSpeciality { get; set; }

    public long? PrimaryReferringPhycianSer { get; set; }

    [StringLength(64)]
    public string? AliasName { get; set; }
}
