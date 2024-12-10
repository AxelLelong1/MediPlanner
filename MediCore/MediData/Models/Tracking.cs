using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("TrackingUid", Name = "XAK1Tracking", IsUnique = true)]
[Index("SeriesSer", Name = "XIF851Tracking")]
[Index("EquipmentSer", Name = "XIF895Tracking")]
[Index("PlanSetupSer", Name = "XIF944Tracking")]
public partial class Tracking
{
    [Key]
    public long TrackingSer { get; set; }

    public long SeriesSer { get; set; }

    public long? PlanSetupSer { get; set; }

    [StringLength(16)]
    public string TrackingId { get; set; } = null!;

    [StringLength(64)]
    public string? TrackingName { get; set; }

    [Column("TrackingUID")]
    [StringLength(64)]
    public string TrackingUid { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    public short TrackingType { get; set; }

    public long? EquipmentSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }

    [ForeignKey("EquipmentSer")]
    [InverseProperty("Tracking")]
    public virtual Equipment? EquipmentSerNavigation { get; set; }

    [InverseProperty("TrackingSerNavigation")]
    public virtual ICollection<ExternalField> ExternalField { get; set; } = new List<ExternalField>();

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("Tracking")]
    public virtual PlanSetup? PlanSetupSerNavigation { get; set; }

    [InverseProperty("ReferenceWaveformSerNavigation")]
    public virtual ICollection<RefWaveformRelation> RefWaveformRelationReferenceWaveformSerNavigation { get; set; } = new List<RefWaveformRelation>();

    [InverseProperty("TrackingSerNavigation")]
    public virtual ICollection<RefWaveformRelation> RefWaveformRelationTrackingSerNavigation { get; set; } = new List<RefWaveformRelation>();

    [ForeignKey("SeriesSer")]
    [InverseProperty("Tracking")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("TrackingSerNavigation")]
    public virtual ICollection<TrackingField> TrackingField { get; set; } = new List<TrackingField>();

    [InverseProperty("TrackingSerNavigation")]
    public virtual ICollection<TrackingImage> TrackingImage { get; set; } = new List<TrackingImage>();
}
