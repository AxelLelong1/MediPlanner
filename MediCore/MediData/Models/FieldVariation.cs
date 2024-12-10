using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanVariationSer", Name = "XIF1FieldVariation")]
[Index("RadiationSer", Name = "XIF2FieldVariation")]
public partial class FieldVariation
{
    [Key]
    public long FieldVariationSer { get; set; }

    public long PlanVariationSer { get; set; }

    public long RadiationSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("HUConversionError")]
    public double? HuconversionError { get; set; }

    public double? IsocenterShiftX { get; set; }

    public double? IsocenterShiftY { get; set; }

    public double? IsocenterShiftZ { get; set; }

    /// <summary>
    /// Contextual details relating to this field variation. May for example contain a key-value type data structure encoded as a string. 
    /// The data contained in a row is described in &quot;FieldVariationParameters Data Description&quot; document.
    /// </summary>
    public string? FieldVariationParameters { get; set; }

    [InverseProperty("FieldVariationSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("FieldVariationSerNavigation")]
    public virtual ICollection<Matrix> Matrix { get; set; } = new List<Matrix>();

    [ForeignKey("PlanVariationSer")]
    [InverseProperty("FieldVariation")]
    public virtual PlanVariation PlanVariationSerNavigation { get; set; } = null!;

    [ForeignKey("RadiationSer")]
    [InverseProperty("FieldVariation")]
    public virtual Radiation RadiationSerNavigation { get; set; } = null!;
}
