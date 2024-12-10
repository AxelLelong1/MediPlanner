using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetPrimaryOncologist
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

    [Column("Primary Oncologist Full Name")]
    [StringLength(130)]
    public string? PrimaryOncologistFullName { get; set; }

    [Column("Primary Oncologist Speciality")]
    [StringLength(64)]
    public string? PrimaryOncologistSpeciality { get; set; }

    public long? PrimaryOncologistSer { get; set; }

    [StringLength(64)]
    public string? AliasName { get; set; }
}
