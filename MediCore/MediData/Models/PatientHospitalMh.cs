using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("HospitalSer", "PatientSer", "PatientHospitalRevCount")]
[Table("PatientHospitalMH")]
public partial class PatientHospitalMh
{
    [Key]
    public long HospitalSer { get; set; }

    [Key]
    public long PatientSer { get; set; }

    [Key]
    public int PatientHospitalRevCount { get; set; }

    public long? CacheKeySer { get; set; }

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

    [ForeignKey("HospitalSer, PatientSer")]
    [InverseProperty("PatientHospitalMh")]
    public virtual PatientHospital PatientHospital { get; set; } = null!;
}
