using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("HospitalSer", "PatientSer")]
[Index("PatientSer", Name = "XIF347PatientInHospital")]
public partial class PatientHospital
{
    [Key]
    public long HospitalSer { get; set; }

    [Key]
    public long PatientSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int PatientHospitalRevCount { get; set; }

    public int InPatientFlag { get; set; }

    [StringLength(16)]
    public string? PatientLocation { get; set; }

    [StringLength(32)]
    public string? PatientStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProjectedEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("HospitalSer")]
    [InverseProperty("PatientHospital")]
    public virtual Hospital HospitalSerNavigation { get; set; } = null!;

    [InverseProperty("PatientHospital")]
    public virtual ICollection<PatientHospitalMh> PatientHospitalMh { get; set; } = new List<PatientHospitalMh>();

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientHospital")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
