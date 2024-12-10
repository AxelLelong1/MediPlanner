using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DiagnosisSer", "PatientSer")]
[Index("PatientSer", Name = "XIF343Diagnosis")]
[Index("PatientSer", Name = "nc1_Diagnosis")]
[Index("DiagnosisId", Name = "nc2_Diagnosis")]
public partial class Diagnosis
{
    [Key]
    public long DiagnosisSer { get; set; }

    [Key]
    public long PatientSer { get; set; }

    [StringLength(16)]
    public string? DiagnosisId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateStamp { get; set; }

    [StringLength(64)]
    public string? DiagnosisTableName { get; set; }

    [StringLength(16)]
    public string? DiagnosisCode { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(64)]
    public string? HistologyTableName { get; set; }

    [StringLength(16)]
    public string? HistologyCode { get; set; }

    [StringLength(254)]
    public string? HisDescription { get; set; }

    [StringLength(30)]
    public string? DiagnosisType { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [MaxLength(8)]
    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(16)]
    public string? ObjectStatus { get; set; }
}
