using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("StaffId", Name = "XAK1Staff", IsUnique = true)]
[Index("AliasName", Name = "XAK2Staff", IsUnique = true)]
[Index("LastName", "FirstName", "MiddleName", Name = "XIE1Staff")]
public partial class Staff
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string StaffId { get; set; } = null!;

    [StringLength(16)]
    public string? Honorific { get; set; }

    [StringLength(64)]
    public string FirstName { get; set; } = null!;

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(64)]
    public string AliasName { get; set; } = null!;

    [StringLength(64)]
    public string? Profession { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int AdvancedPractitionerFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    public int ExternalMedOncFlag { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<PatientStaff> PatientStaff { get; set; } = new List<PatientStaff>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("Staff")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<StaffMh> StaffMh { get; set; } = new List<StaffMh>();
}
