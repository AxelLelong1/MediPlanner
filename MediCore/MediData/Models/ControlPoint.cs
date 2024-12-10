using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RadiationSer", "ControlPointIndex", Name = "XAK1ControlPoint", IsUnique = true)]
[Index("HstryDateTime", Name = "XIE1ControlPoint")]
public partial class ControlPoint
{
    [Key]
    public long ControlPointSer { get; set; }

    public long RadiationSer { get; set; }

    public int ControlPointIndex { get; set; }

    [StringLength(30)]
    public string ControlPointType { get; set; } = null!;

    public double MetersetWeight { get; set; }

    public int? NominalEnergy { get; set; }

    public double? CollX1 { get; set; }

    public double? CollX2 { get; set; }

    public double? CollY1 { get; set; }

    public double? CollY2 { get; set; }

    public double? GantryRtn { get; set; }

    public double? CollRtn { get; set; }

    public double? OffPlaneAngle { get; set; }

    public short? PlanPosLeaf1A { get; set; }

    public short? PlanPosLeaf2A { get; set; }

    public short? PlanPosLeaf3A { get; set; }

    public short? PlanPosLeaf4A { get; set; }

    public short? PlanPosLeaf5A { get; set; }

    public short? PlanPosLeaf6A { get; set; }

    public short? PlanPosLeaf7A { get; set; }

    public short? PlanPosLeaf8A { get; set; }

    public short? PlanPosLeaf9A { get; set; }

    public short? PlanPosLeaf10A { get; set; }

    public short? PlanPosLeaf11A { get; set; }

    public short? PlanPosLeaf12A { get; set; }

    public short? PlanPosLeaf13A { get; set; }

    public short? PlanPosLeaf14A { get; set; }

    public short? PlanPosLeaf15A { get; set; }

    public short? PlanPosLeaf16A { get; set; }

    public short? PlanPosLeaf17A { get; set; }

    public short? PlanPosLeaf18A { get; set; }

    public short? PlanPosLeaf19A { get; set; }

    public short? PlanPosLeaf20A { get; set; }

    public short? PlanPosLeaf21A { get; set; }

    public short? PlanPosLeaf22A { get; set; }

    public short? PlanPosLeaf23A { get; set; }

    public short? PlanPosLeaf24A { get; set; }

    public short? PlanPosLeaf25A { get; set; }

    public short? PlanPosLeaf26A { get; set; }

    public short? PlanPosLeaf27A { get; set; }

    public short? PlanPosLeaf28A { get; set; }

    public short? PlanPosLeaf29A { get; set; }

    public short? PlanPosLeaf30A { get; set; }

    public short? PlanPosLeaf31A { get; set; }

    public short? PlanPosLeaf32A { get; set; }

    public short? PlanPosLeaf33A { get; set; }

    public short? PlanPosLeaf34A { get; set; }

    public short? PlanPosLeaf35A { get; set; }

    public short? PlanPosLeaf36A { get; set; }

    public short? PlanPosLeaf37A { get; set; }

    public short? PlanPosLeaf38A { get; set; }

    public short? PlanPosLeaf39A { get; set; }

    public short? PlanPosLeaf40A { get; set; }

    public short? PlanPosLeaf41A { get; set; }

    public short? PlanPosLeaf42A { get; set; }

    public short? PlanPosLeaf43A { get; set; }

    public short? PlanPosLeaf44A { get; set; }

    public short? PlanPosLeaf45A { get; set; }

    public short? PlanPosLeaf46A { get; set; }

    public short? PlanPosLeaf47A { get; set; }

    public short? PlanPosLeaf48A { get; set; }

    public short? PlanPosLeaf49A { get; set; }

    public short? PlanPosLeaf50A { get; set; }

    public short? PlanPosLeaf51A { get; set; }

    public short? PlanPosLeaf52A { get; set; }

    public short? PlanPosLeaf53A { get; set; }

    public short? PlanPosLeaf54A { get; set; }

    public short? PlanPosLeaf55A { get; set; }

    public short? PlanPosLeaf56A { get; set; }

    public short? PlanPosLeaf57A { get; set; }

    public short? PlanPosLeaf58A { get; set; }

    public short? PlanPosLeaf59A { get; set; }

    public short? PlanPosLeaf60A { get; set; }

    public short? PlanPosLeaf61A { get; set; }

    public short? PlanPosLeaf62A { get; set; }

    public short? PlanPosLeaf63A { get; set; }

    public short? PlanPosLeaf64A { get; set; }

    public short? PlanPosLeaf65A { get; set; }

    public short? PlanPosLeaf66A { get; set; }

    public short? PlanPosLeaf67A { get; set; }

    public short? PlanPosLeaf68A { get; set; }

    public short? PlanPosLeaf69A { get; set; }

    public short? PlanPosLeaf70A { get; set; }

    public short? PlanPosLeaf71A { get; set; }

    public short? PlanPosLeaf72A { get; set; }

    public short? PlanPosLeaf73A { get; set; }

    public short? PlanPosLeaf74A { get; set; }

    public short? PlanPosLeaf75A { get; set; }

    public short? PlanPosLeaf76A { get; set; }

    public short? PlanPosLeaf77A { get; set; }

    public short? PlanPosLeaf78A { get; set; }

    public short? PlanPosLeaf79A { get; set; }

    public short? PlanPosLeaf80A { get; set; }

    public short? PlanPosLeaf1B { get; set; }

    public short? PlanPosLeaf2B { get; set; }

    public short? PlanPosLeaf3B { get; set; }

    public short? PlanPosLeaf4B { get; set; }

    public short? PlanPosLeaf5B { get; set; }

    public short? PlanPosLeaf6B { get; set; }

    public short? PlanPosLeaf7B { get; set; }

    public short? PlanPosLeaf8B { get; set; }

    public short? PlanPosLeaf9B { get; set; }

    public short? PlanPosLeaf10B { get; set; }

    public short? PlanPosLeaf11B { get; set; }

    public short? PlanPosLeaf12B { get; set; }

    public short? PlanPosLeaf13B { get; set; }

    public short? PlanPosLeaf14B { get; set; }

    public short? PlanPosLeaf15B { get; set; }

    public short? PlanPosLeaf16B { get; set; }

    public short? PlanPosLeaf17B { get; set; }

    public short? PlanPosLeaf18B { get; set; }

    public short? PlanPosLeaf19B { get; set; }

    public short? PlanPosLeaf20B { get; set; }

    public short? PlanPosLeaf21B { get; set; }

    public short? PlanPosLeaf22B { get; set; }

    public short? PlanPosLeaf23B { get; set; }

    public short? PlanPosLeaf24B { get; set; }

    public short? PlanPosLeaf25B { get; set; }

    public short? PlanPosLeaf26B { get; set; }

    public short? PlanPosLeaf27B { get; set; }

    public short? PlanPosLeaf28B { get; set; }

    public short? PlanPosLeaf29B { get; set; }

    public short? PlanPosLeaf30B { get; set; }

    public short? PlanPosLeaf31B { get; set; }

    public short? PlanPosLeaf32B { get; set; }

    public short? PlanPosLeaf33B { get; set; }

    public short? PlanPosLeaf34B { get; set; }

    public short? PlanPosLeaf35B { get; set; }

    public short? PlanPosLeaf36B { get; set; }

    public short? PlanPosLeaf37B { get; set; }

    public short? PlanPosLeaf38B { get; set; }

    public short? PlanPosLeaf39B { get; set; }

    public short? PlanPosLeaf40B { get; set; }

    public short? PlanPosLeaf41B { get; set; }

    public short? PlanPosLeaf42B { get; set; }

    public short? PlanPosLeaf43B { get; set; }

    public short? PlanPosLeaf44B { get; set; }

    public short? PlanPosLeaf45B { get; set; }

    public short? PlanPosLeaf46B { get; set; }

    public short? PlanPosLeaf47B { get; set; }

    public short? PlanPosLeaf48B { get; set; }

    public short? PlanPosLeaf49B { get; set; }

    public short? PlanPosLeaf50B { get; set; }

    public short? PlanPosLeaf51B { get; set; }

    public short? PlanPosLeaf52B { get; set; }

    public short? PlanPosLeaf53B { get; set; }

    public short? PlanPosLeaf54B { get; set; }

    public short? PlanPosLeaf55B { get; set; }

    public short? PlanPosLeaf56B { get; set; }

    public short? PlanPosLeaf57B { get; set; }

    public short? PlanPosLeaf58B { get; set; }

    public short? PlanPosLeaf59B { get; set; }

    public short? PlanPosLeaf60B { get; set; }

    public short? PlanPosLeaf61B { get; set; }

    public short? PlanPosLeaf62B { get; set; }

    public short? PlanPosLeaf63B { get; set; }

    public short? PlanPosLeaf64B { get; set; }

    public short? PlanPosLeaf65B { get; set; }

    public short? PlanPosLeaf66B { get; set; }

    public short? PlanPosLeaf67B { get; set; }

    public short? PlanPosLeaf68B { get; set; }

    public short? PlanPosLeaf69B { get; set; }

    public short? PlanPosLeaf70B { get; set; }

    public short? PlanPosLeaf71B { get; set; }

    public short? PlanPosLeaf72B { get; set; }

    public short? PlanPosLeaf73B { get; set; }

    public short? PlanPosLeaf74B { get; set; }

    public short? PlanPosLeaf75B { get; set; }

    public short? PlanPosLeaf76B { get; set; }

    public short? PlanPosLeaf77B { get; set; }

    public short? PlanPosLeaf78B { get; set; }

    public short? PlanPosLeaf79B { get; set; }

    public short? PlanPosLeaf80B { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public double? PatientSupportAngle { get; set; }

    public double? IsoCenterPositionX { get; set; }

    public double? IsoCenterPositionY { get; set; }

    public double? IsoCenterPositionZ { get; set; }

    [InverseProperty("ControlPointSerNavigation")]
    public virtual ControlPointProton? ControlPointProton { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("ControlPoint")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;
}
