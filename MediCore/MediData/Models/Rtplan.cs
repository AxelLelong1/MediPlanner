using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RTPlan")]
[Index("PlanUid", Name = "XAK1RTPlan", IsUnique = true)]
[Index("PlanSetupSer", Name = "XIF1RTPlan")]
[Index("SeriesSer", Name = "XIF5RTPlan")]
[Index("PlanSopclassSer", Name = "XIF6RTPlan")]
public partial class Rtplan
{
    [Key]
    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Column("PlanSOPClassSer")]
    public long PlanSopclassSer { get; set; }

    [Column("PlanUID")]
    [StringLength(64)]
    public string PlanUid { get; set; } = null!;

    public long PlanSetupSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    public int? NoFractions { get; set; }

    public int? StartDelay { get; set; }

    public int DicomSeqNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int? InterfaceStamp { get; set; }

    public double? PrescribedDose { get; set; }

    public long SeriesSer { get; set; }

    public byte[]? PlanIntegrityHash { get; set; }

    public int? PlanHashVersion { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int? TreatmentOrder { get; set; }

    [StringLength(254)]
    public string? FileName { get; set; }

    public int? FractionPatternDigitsPerDay { get; set; }

    [StringLength(64)]
    public string? FractionPattern { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }

    [InverseProperty("RtplanSerNavigation")]
    public virtual ICollection<DoseContribution> DoseContribution { get; set; } = new List<DoseContribution>();

    [InverseProperty("RelatedRtplanSerNavigation")]
    public virtual ICollection<PlanRelationship> PlanRelationshipRelatedRtplanSerNavigation { get; set; } = new List<PlanRelationship>();

    [InverseProperty("RtplanSerNavigation")]
    public virtual ICollection<PlanRelationship> PlanRelationshipRtplanSerNavigation { get; set; } = new List<PlanRelationship>();

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("Rtplan")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;

    [ForeignKey("PlanSopclassSer")]
    [InverseProperty("Rtplan")]
    public virtual Sopclass PlanSopclassSerNavigation { get; set; } = null!;

    [InverseProperty("RtplanSerNavigation")]
    public virtual ICollection<RadiationRefPoint> RadiationRefPoint { get; set; } = new List<RadiationRefPoint>();

    [ForeignKey("SeriesSer")]
    [InverseProperty("Rtplan")]
    public virtual Series SeriesSerNavigation { get; set; } = null!;

    [InverseProperty("RtplanSerNavigation")]
    public virtual ICollection<SessionProcedurePart> SessionProcedurePart { get; set; } = new List<SessionProcedurePart>();

    [InverseProperty("RtplanSerNavigation")]
    public virtual ICollection<SessionRtplan> SessionRtplan { get; set; } = new List<SessionRtplan>();

    [InverseProperty("RtplanSerNavigation")]
    public virtual ICollection<TreatmentRecord> TreatmentRecord { get; set; } = new List<TreatmentRecord>();
}
