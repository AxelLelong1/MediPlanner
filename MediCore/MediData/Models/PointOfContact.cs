using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", Name = "XIF756PointOfContact")]
[Index("AddressSer", Name = "XIF757PointOfContact")]
public partial class PointOfContact
{
    [Key]
    public long PointOfContactSer { get; set; }

    public long? AddressSer { get; set; }

    public long PatientSer { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(64)]
    public string? Relationship { get; set; }

    [StringLength(16)]
    public string? Honorific { get; set; }

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [StringLength(64)]
    public string? FirstNameUpper { get; set; }

    [StringLength(64)]
    public string? LastNameUpper { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    [StringLength(64)]
    public string? WorkPhone { get; set; }

    [StringLength(64)]
    public string? HomePhone { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column("CreatedByHL7")]
    [StringLength(255)]
    public string? CreatedByHl7 { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? MobilePhone { get; set; }

    public int EntrustedContactFlag { get; set; }

    [ForeignKey("AddressSer")]
    [InverseProperty("PointOfContact")]
    public virtual Address? AddressSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PointOfContact")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
