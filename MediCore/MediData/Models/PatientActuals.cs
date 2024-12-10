using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("FirstNameUpper", "LastNameUpper", Name = "XIE1PatientActuals")]
[Index("PatientIdUpper", Name = "XIE2PatientActuals")]
[Index("PatientId2Upper", Name = "XIE3PatientActuals")]
[Index("LastNameUpper", Name = "XIE4PatientActuals")]
public partial class PatientActuals
{
    [Key]
    public long PatientSer { get; set; }

    [StringLength(25)]
    public string PatientIdUpper { get; set; } = null!;

    [StringLength(25)]
    public string? PatientId2Upper { get; set; }

    [StringLength(64)]
    public string? FirstNameUpper { get; set; }

    [StringLength(64)]
    public string? LastNameUpper { get; set; }

    [Column("SSN")]
    [StringLength(64)]
    public string? Ssn { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    public long? HospitalSer { get; set; }

    public int InPatientFlag { get; set; }

    [StringLength(16)]
    public string? PatientLocation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ArrivalTime { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    public int? SelectionStatus { get; set; }

    [Column("LastImagePIDate", TypeName = "datetime")]
    public DateTime? LastImagePidate { get; set; }

    [Column("LastImageSIDate", TypeName = "datetime")]
    public DateTime? LastImageSidate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastOtherImageDate { get; set; }

    public int DirectiveAskedFlag { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientActuals")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
