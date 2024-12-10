using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HstryDateTime", "LoginName", "PatientId", Name = "XIE1AuditLog")]
[Index("PatientId", Name = "XIE2AuditLog")]
public partial class AuditLog
{
    [Key]
    public long AuditLogSer { get; set; }

    [StringLength(32)]
    public string AuditType { get; set; } = null!;

    public int Spid { get; set; }

    public int Suid { get; set; }

    [StringLength(32)]
    public string LoginName { get; set; } = null!;

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    [StringLength(16)]
    public string? DiagnosisId { get; set; }

    [StringLength(64)]
    public string? DiagnosisTableName { get; set; }

    [StringLength(16)]
    public string? DiagnosisCode { get; set; }

    [StringLength(16)]
    public string? CourseId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string ProcName { get; set; } = null!;

    [StringLength(254)]
    public string? ExtraInfo { get; set; }
}
