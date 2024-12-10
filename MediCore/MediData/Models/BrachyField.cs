using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("BrachySolidApplicatorSer", Name = "XIF2BrachyField")]
[Index("BrachyApplicatorSer", Name = "XIF3BrachyField")]
[Index("ChannelSer", Name = "XIF4BrachyField")]
public partial class BrachyField
{
    [Key]
    public long RadiationSer { get; set; }

    public long? ChannelSer { get; set; }

    public long? BrachyApplicatorSer { get; set; }

    [StringLength(32)]
    public string? BrachyFieldTypeInfo { get; set; }

    public double? ApplicatorLength { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PlannedTreatmDateTime { get; set; }

    public double? StepSize { get; set; }

    public double? FirstSourcePosition { get; set; }

    public double? LastSourcePosition { get; set; }

    public int? AutomaticPosFlag { get; set; }

    public long? BrachySolidApplicatorSer { get; set; }

    [Column("ApplicatorPartChannelUID")]
    public int? ApplicatorPartChannelUid { get; set; }

    /// <summary>
    /// Amount of dead space in millimeters from the tip of the applicator to the start of the inner lumen of the applicator. Must be non-negative.
    /// </summary>
    public double? DeadSpace { get; set; }

    [ForeignKey("BrachyApplicatorSer")]
    [InverseProperty("BrachyField")]
    public virtual BrachyApplicator? BrachyApplicatorSerNavigation { get; set; }

    [ForeignKey("BrachySolidApplicatorSer")]
    [InverseProperty("BrachyField")]
    public virtual BrachySolidApplicator? BrachySolidApplicatorSerNavigation { get; set; }

    [ForeignKey("ChannelSer")]
    [InverseProperty("BrachyField")]
    public virtual Channel? ChannelSerNavigation { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("BrachyField")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<SourcePosition> SourcePosition { get; set; } = new List<SourcePosition>();
}
