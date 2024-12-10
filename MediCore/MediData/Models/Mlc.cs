using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MLC")]
public partial class Mlc
{
    [Key]
    public long AddOnSer { get; set; }

    [StringLength(254)]
    public string? ManufacturerName { get; set; }

    [Column("MLCSerialNumber")]
    [StringLength(64)]
    public string? MlcserialNumber { get; set; }

    [Column("MLCModel")]
    [StringLength(64)]
    public string? Mlcmodel { get; set; }

    public double? Rotation { get; set; }

    [StringLength(64)]
    public string? SupportedFiles { get; set; }

    public int ArcEnableFlag { get; set; }

    public int DoseEnableFlag { get; set; }

    public double MinDoseDynamicLeafGap { get; set; }

    public double MinArcDynamicLeafGap { get; set; }

    public double MaxLeafSpeed { get; set; }

    public double DoseDynamicLeafTolerance { get; set; }

    public double ArcDynamicLeafTolerance { get; set; }

    public double? MinStaticLeafGap { get; set; }

    public double MinSegmentThreshold { get; set; }

    public int MaxControlPoints { get; set; }

    public double? SourceDistance { get; set; }

    public double? ParallelJawSetBack { get; set; }

    public double? PerpendicularJawSetBack { get; set; }

    public double? MaxPerpendicularJawOpening { get; set; }

    public double NominalLeafLength { get; set; }

    [Column("FitMLCToBlockMarginDefault")]
    public double? FitMlctoBlockMarginDefault { get; set; }

    [Column("FitMLCToBlockMarginMethodDefault")]
    public short? FitMlctoBlockMarginMethodDefault { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Mlc")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("AddOnSerNavigation")]
    public virtual ICollection<Mlcbank> Mlcbank { get; set; } = new List<Mlcbank>();
}
