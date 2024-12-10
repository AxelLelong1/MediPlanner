using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactInVivoDosimetryIncr
{
    [Column("InVivoDateID")]
    [StringLength(10)]
    [Unicode(false)]
    public string InVivoDateId { get; set; } = null!;

    [StringLength(255)]
    public string? UserName { get; set; }

    [StringLength(255)]
    public string CreationUserName { get; set; } = null!;

    [Column("CreationDateID")]
    [StringLength(10)]
    [Unicode(false)]
    public string CreationDateId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InVivoDate { get; set; }

    [StringLength(64)]
    public string InVivoVendorName { get; set; } = null!;

    [StringLength(64)]
    public string? DosimeterType { get; set; }

    [StringLength(64)]
    public string DosimeterId { get; set; } = null!;

    [StringLength(128)]
    public string DosimeterLocation { get; set; } = null!;

    [StringLength(16)]
    public string FieldId { get; set; } = null!;

    [StringLength(64)]
    public string? FieldName { get; set; }

    public double? ExpectedDose { get; set; }

    public double? DeliveredDose { get; set; }

    public double? ToleranceValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string? PlanUid { get; set; }

    public int? FieldGroupNumber { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("ctrInVivoDosimetrySer")]
    public long CtrInVivoDosimetrySer { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }
}
