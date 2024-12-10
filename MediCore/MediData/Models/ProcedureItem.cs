using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DicomcodeValueSer", Name = "XIF1ProcedureItem")]
public partial class ProcedureItem
{
    [Key]
    public long ProcedureItemSer { get; set; }

    [Column("DICOMCodeValueSer")]
    public long DicomcodeValueSer { get; set; }

    public int? Duration { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(16)]
    public string ProcedureItemType { get; set; } = null!;

    public int NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(64)]
    public string? ProcedureItemLabel { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ProcedureItemSerNavigation")]
    public virtual ICollection<ActivityToProcedureItem> ActivityToProcedureItem { get; set; } = new List<ActivityToProcedureItem>();

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("ProcedureItem")]
    public virtual DicomcodeValue DicomcodeValueSerNavigation { get; set; } = null!;

    [InverseProperty("ProcedureItemSerNavigation")]
    public virtual ICollection<ProcedureItemResource> ProcedureItemResource { get; set; } = new List<ProcedureItemResource>();

    [InverseProperty("ProcedureItemSerNavigation")]
    public virtual ICollection<ProcedureItemSopclass> ProcedureItemSopclass { get; set; } = new List<ProcedureItemSopclass>();

    [InverseProperty("ProcedureItemSerNavigation")]
    public virtual ICollection<ScheduledProcedureItem> ScheduledProcedureItem { get; set; } = new List<ScheduledProcedureItem>();

    [InverseProperty("ProcedureItemSerNavigation")]
    public virtual ICollection<SessionProcedure> SessionProcedure { get; set; } = new List<SessionProcedure>();
}
