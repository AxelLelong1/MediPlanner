using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ADT08")]
[Index("InternalId", Name = "XAK1ADT08", IsUnique = true)]
[Index("PatientId", Name = "XAK3ADT08", IsUnique = true)]
[Index("PatientSer", Name = "XIF787ADT08")]
public partial class Adt08
{
    [Key]
    [Column("ADT08Ser")]
    public long Adt08ser { get; set; }

    [StringLength(32)]
    public string InternalId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(25)]
    public string? PatientId2 { get; set; }

    [Column("SSN")]
    [StringLength(64)]
    public string? Ssn { get; set; }

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? MiddleName { get; set; }

    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [StringLength(16)]
    public string? Honorific { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(16)]
    public string? Sex { get; set; }

    [StringLength(64)]
    public string? Country { get; set; }

    [StringLength(64)]
    public string? StateOrProvince { get; set; }

    [StringLength(64)]
    public string? CityOrTownship { get; set; }

    [StringLength(64)]
    public string? AddressLine1 { get; set; }

    [StringLength(64)]
    public string? AddressLine2 { get; set; }

    [StringLength(16)]
    public string? PostalCode { get; set; }

    [StringLength(64)]
    public string? WorkPhone { get; set; }

    [StringLength(64)]
    public string? HomePhone { get; set; }

    public int? InSyncFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("Adt08")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
