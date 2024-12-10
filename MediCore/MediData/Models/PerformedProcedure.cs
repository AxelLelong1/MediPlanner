using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DicomcodeValueSer", Name = "XIF1PerformedProcedure")]
[Index("ActivityInstanceSer", Name = "XIF2PerformedProcedure")]
public partial class PerformedProcedure
{
    [Key]
    public long PerformedProcedureSer { get; set; }

    [StringLength(16)]
    public string? PerformedProcedureId { get; set; }

    [Column("PerformedProcedureUID")]
    [StringLength(64)]
    public string? PerformedProcedureUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDateTime { get; set; }

    [StringLength(64)]
    public string? Description { get; set; }

    [StringLength(16)]
    public string? Modality { get; set; }

    [StringLength(64)]
    public string? Operator1 { get; set; }

    [StringLength(64)]
    public string? Operator2 { get; set; }

    [StringLength(64)]
    public string? Operator3 { get; set; }

    [Column("DICOMCodeValueSer")]
    public long? DicomcodeValueSer { get; set; }

    [StringLength(64)]
    public string? DiscReasonCodeMeaning { get; set; }

    [StringLength(16)]
    public string? Status { get; set; }

    [StringLength(64)]
    public string? ProtocolName { get; set; }

    public long ActivityInstanceSer { get; set; }

    public int ActivityInstanceRevCount { get; set; }

    public double? Progress { get; set; }

    [Column("TransactionUID")]
    [StringLength(64)]
    public string? TransactionUid { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("PerformedProcedure")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("PerformedProcedure")]
    public virtual DicomcodeValue? DicomcodeValueSerNavigation { get; set; }

    [InverseProperty("PerformedProcedureSerNavigation")]
    public virtual ICollection<ScheduledPerformedProcedure> ScheduledPerformedProcedure { get; set; } = new List<ScheduledPerformedProcedure>();

    [ForeignKey("PerformedProcedureSer")]
    [InverseProperty("PerformedProcedureSer")]
    public virtual ICollection<ObjectPointer> ObjectPointerSer { get; set; } = new List<ObjectPointer>();
}
