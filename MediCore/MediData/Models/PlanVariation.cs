using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanSetupSer", Name = "XIF1PlanVariation")]
public partial class PlanVariation
{
    [Key]
    public long PlanVariationSer { get; set; }

    public long PlanSetupSer { get; set; }

    [StringLength(64)]
    public string? PlanVariationId { get; set; }

    /// <summary>
    /// Allowed values: &quot;RangeUncertainty&quot;, &quot;IsocenterShiftUncertainty&quot;, &quot;BaselineShiftUncertainty&quot;, 
    /// &quot;MLCTrackingVariation&quot;, &quot;CouchTrackingVariation&quot;, &quot;RobustOptimization&quot;, &quot;McoTradeOff&quot;
    /// </summary>
    [StringLength(32)]
    public string PlanVariationType { get; set; } = null!;

    [Column("HUConversionError")]
    public double? HuconversionError { get; set; }

    public double? IsocenterShiftX { get; set; }

    public double? IsocenterShiftY { get; set; }

    public double? IsocenterShiftZ { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    /// <summary>
    /// Contextual details relating to this plan variation. May for example contain a key-value type data structure encoded as a string. 
    /// The data contained in a row is described in &quot;PlanVariationParameters Data Description&quot; document.
    /// </summary>
    public string? PlanVariationParameters { get; set; }

    [InverseProperty("PlanVariationSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("PlanVariationSerNavigation")]
    public virtual ICollection<FieldVariation> FieldVariation { get; set; } = new List<FieldVariation>();

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("PlanVariation")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;
}
