using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Index("TableName", "AttribName", "EventId", Name = "XIE2PatientEditingLog")]
[Index("Uid", Name = "XIE3PatientEditingLog")]
[Index("PatientEditingLogSer", "PatientSer", Name = "XIE4PatientEditingLog")]
[Index("PatientSer", Name = "XIF487PatientEditingLog")]
public partial class PatientEditingLog
{
    public long PatientEditingLogSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(30)]
    public string? TableName { get; set; }

    [StringLength(32)]
    public string? AttribName { get; set; }

    public int? EventId { get; set; }

    public long? Key1 { get; set; }

    public long? Key2 { get; set; }

    public long? Key3 { get; set; }

    [StringLength(16)]
    public string? TableId { get; set; }

    [Column("UID")]
    [StringLength(64)]
    public string? Uid { get; set; }

    [StringLength(254)]
    public string? OldValue { get; set; }

    [StringLength(254)]
    public string? NewValue { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("PatientSer")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;
}
