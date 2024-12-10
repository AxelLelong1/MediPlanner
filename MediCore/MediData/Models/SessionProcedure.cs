using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("Status", "SessionSer", Name = "XIE1SessionProcedure")]
[Index("SessionSer", Name = "XIF1SessionProcedure")]
[Index("SeriesSer", Name = "XIF2SessionProcedure")]
[Index("ProcedureItemSer", Name = "XIF3SessionProcedure")]
public partial class SessionProcedure
{
    [Key]
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

    [ForeignKey("ProcedureItemSer")]
    [InverseProperty("SessionProcedure")]
    public virtual ProcedureItem? ProcedureItemSerNavigation { get; set; }

    [ForeignKey("SeriesSer")]
    [InverseProperty("SessionProcedure")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("SessionProcedureSerNavigation")]
    public virtual ICollection<SessionProcedurePart> SessionProcedurePart { get; set; } = new List<SessionProcedurePart>();

    [ForeignKey("SessionSer")]
    [InverseProperty("SessionProcedure")]
    public virtual Session SessionSerNavigation { get; set; } = null!;
}
