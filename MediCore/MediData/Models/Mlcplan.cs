using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MLCPlan")]
[Index("RadiationSer", "MlcplanId", Name = "XAKMLCPlan", IsUnique = true)]
[Index("HstryDateTime", Name = "XIE1MLCPlan")]
public partial class Mlcplan
{
    [Key]
    [Column("MLCPlanSer")]
    public long MlcplanSer { get; set; }

    public long RadiationSer { get; set; }

    [Column("MLCPlanId")]
    [StringLength(16)]
    public string MlcplanId { get; set; } = null!;

    [Column("MLCPlanName")]
    [StringLength(64)]
    public string? MlcplanName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [Column("MLCPlanType")]
    [StringLength(30)]
    public string MlcplanType { get; set; } = null!;

    [StringLength(32)]
    public string? IndexParameterType { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int IsLockedFlag { get; set; }

    public int EllipticalMarginFlag { get; set; }

    [Column("BEVMarginFlag")]
    public int BevmarginFlag { get; set; }

    public double? LeftMargin { get; set; }

    public double? RightMargin { get; set; }

    public double? TopMargin { get; set; }

    public double? BottomMargin { get; set; }

    [StringLength(32)]
    public string? ContourMeetPoint { get; set; }

    [StringLength(32)]
    public string? ClosedMeetPoint { get; set; }

    public int OptimizeCollRtnFlag { get; set; }

    public int? CollimatorJawOptimization { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("FitMLCToBlockMargin")]
    public double? FitMlctoBlockMargin { get; set; }

    [Column("FitMLCToBlockMarginMethod")]
    public short? FitMlctoBlockMarginMethod { get; set; }

    [InverseProperty("MlcplanSerNavigation")]
    public virtual ICollection<Matrix> Matrix { get; set; } = new List<Matrix>();

    [ForeignKey("RadiationSer")]
    [InverseProperty("Mlcplan")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;
}
