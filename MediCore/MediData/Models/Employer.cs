using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("EmployerId", Name = "XAK1Employer", IsUnique = true)]
[Index("EmployerName", "DivisionName", Name = "XIE1Employer")]
[Index("PatientSer", Name = "XIF662Employer")]
[Index("AddressSer", Name = "XIF663Employer")]
public partial class Employer
{
    [Key]
    public long EmployerSer { get; set; }

    public long? AddressSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string EmployerId { get; set; } = null!;

    [StringLength(64)]
    public string? EmployerName { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(64)]
    public string? DivisionName { get; set; }

    [Column("POCName")]
    [StringLength(64)]
    public string? Pocname { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int SchoolFlag { get; set; }

    [ForeignKey("AddressSer")]
    [InverseProperty("Employer")]
    public virtual Address? AddressSerNavigation { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("Employer")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
