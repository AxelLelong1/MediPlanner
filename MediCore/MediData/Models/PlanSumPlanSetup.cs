using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PlanSumSer", "PlanSetupSer")]
[Index("PlanSetupSer", Name = "XIF689PlanSumPlanSetup")]
[Index("RegistrationToReferenceSer", Name = "XIF690PlanSumPlanSetup")]
[Index("RegistrationFromReferenceSer", Name = "XIF691PlanSumPlanSetup")]
public partial class PlanSumPlanSetup
{
    [Key]
    public long PlanSumSer { get; set; }

    [Key]
    public long PlanSetupSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int Sign { get; set; }

    [Column("RBEFactor")]
    public double? Rbefactor { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? RegistrationToReferenceSer { get; set; }

    public long? RegistrationFromReferenceSer { get; set; }

    public double? NumberOfFractionsOverride { get; set; }

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("PlanSumPlanSetup")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;

    [ForeignKey("PlanSumSer")]
    [InverseProperty("PlanSumPlanSetup")]
    public virtual PlanSum PlanSumSerNavigation { get; set; } = null!;

    [ForeignKey("RegistrationFromReferenceSer")]
    [InverseProperty("PlanSumPlanSetupRegistrationFromReferenceSerNavigation")]
    public virtual SpatialRegistrationIod? RegistrationFromReferenceSerNavigation { get; set; }

    [ForeignKey("RegistrationToReferenceSer")]
    [InverseProperty("PlanSumPlanSetupRegistrationToReferenceSerNavigation")]
    public virtual SpatialRegistrationIod? RegistrationToReferenceSerNavigation { get; set; }
}
