using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSessionProcedure
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string PatientType { get; set; } = null!;

    [StringLength(16)]
    public string CourseId { get; set; } = null!;

    public int SessionNum { get; set; }

    public long SessionProcedureSer { get; set; }

    public long SessionSer { get; set; }

    public int? SequenceNumber { get; set; }

    public long SeriesSer { get; set; }

    public long? ProcedureItemSer { get; set; }

    [Column("ProcedureInstanceUID")]
    [StringLength(64)]
    public string? ProcedureInstanceUid { get; set; }

    [StringLength(16)]
    public string SessionProcedureTemplateId { get; set; } = null!;

    [StringLength(16)]
    public string Status { get; set; } = null!;

    public double ProgressIndicator { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
