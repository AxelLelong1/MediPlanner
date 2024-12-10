using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ReferenceWaveformSer", Name = "XIF885RefWaveformRelation")]
[Index("TrackingSer", Name = "XIF886RefWaveformRelation")]
public partial class RefWaveformRelation
{
    [Key]
    public long RefWaveformRelationSer { get; set; }

    public long TrackingSer { get; set; }

    public long ReferenceWaveformSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("RefWaveformRelationSerNavigation")]
    public virtual ICollection<RefWaveformField> RefWaveformField { get; set; } = new List<RefWaveformField>();

    [ForeignKey("ReferenceWaveformSer")]
    [InverseProperty("RefWaveformRelationReferenceWaveformSerNavigation")]
    public virtual Tracking ReferenceWaveformSerNavigation { get; set; } = null!;

    [ForeignKey("TrackingSer")]
    [InverseProperty("RefWaveformRelationTrackingSerNavigation")]
    public virtual Tracking TrackingSerNavigation { get; set; } = null!;
}
