using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class DiagnosisDetail
{
    public long? DiagnosisSer { get; set; }

    public long? PatientSer { get; set; }

    [Column("DiagnosisID")]
    [StringLength(16)]
    public string? DiagnosisId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateStamp { get; set; }

    [StringLength(16)]
    public string? LanguageId { get; set; }

    [StringLength(64)]
    public string? DiagnosisTableName { get; set; }

    [StringLength(16)]
    public string? DiagnosisCode { get; set; }

    [StringLength(254)]
    public string? DiagDescription { get; set; }

    [StringLength(64)]
    public string? HistologyTableName { get; set; }

    [StringLength(16)]
    public string? HistologyCode { get; set; }

    [StringLength(254)]
    public string? HistDescription { get; set; }

    [StringLength(30)]
    public string? DiagnosisType { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(32)]
    public string? HstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [MaxLength(8)]
    public byte[] HstryTimeStamp { get; set; } = null!;

    [StringLength(254)]
    public string? VoiceFileName { get; set; }
}
