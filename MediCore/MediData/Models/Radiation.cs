using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PlanSetupSer", "RadiationSer", Name = "XIE2Radiation")]
[Index("HstryDateTime", Name = "XIE3Radiation")]
[Index("RefImageSopclassSer", Name = "XIF3Radiation")]
[Index("RefImageSer", Name = "XIF4Radiation")]
[Index("ResourceSer", Name = "XIF5Radiation")]
public partial class Radiation
{
    [Key]
    public long RadiationSer { get; set; }

    public long? ResourceSer { get; set; }

    public long PlanSetupSer { get; set; }

    [StringLength(16)]
    public string RadiationId { get; set; } = null!;

    [StringLength(64)]
    public string? RadiationName { get; set; }

    [StringLength(32)]
    public string RadiationType { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int RadiationNumber { get; set; }

    [StringLength(64)]
    public string? TechniqueLabel { get; set; }

    public int? RadiationOrder { get; set; }

    public long? RefImageSer { get; set; }

    [StringLength(254)]
    public string? SetupNote { get; set; }

    [Column("RefImageUID")]
    [StringLength(64)]
    public string? RefImageUid { get; set; }

    [Column("RefImageSOPClassSer")]
    public long? RefImageSopclassSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual BrachyField? BrachyField { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<DoseMatrix> DoseMatrix { get; set; } = new List<DoseMatrix>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ExternalFieldCommon? ExternalFieldCommon { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<FieldPhoto> FieldPhoto { get; set; } = new List<FieldPhoto>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<FieldVariation> FieldVariation { get; set; } = new List<FieldVariation>();

    [ForeignKey("PlanSetupSer")]
    [InverseProperty("Radiation")]
    public virtual PlanSetup PlanSetupSerNavigation { get; set; } = null!;

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<RadiationDeliverySetupDevice> RadiationDeliverySetupDevice { get; set; } = new List<RadiationDeliverySetupDevice>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<RadiationHstry> RadiationHstry { get; set; } = new List<RadiationHstry>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<RadiationRefPoint> RadiationRefPoint { get; set; } = new List<RadiationRefPoint>();

    [ForeignKey("RefImageSer")]
    [InverseProperty("Radiation")]
    public virtual Image1? RefImageSerNavigation { get; set; }

    [ForeignKey("RefImageSopclassSer")]
    [InverseProperty("Radiation")]
    public virtual Sopclass? RefImageSopclassSerNavigation { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Radiation")]
    public virtual RadiationDevice? ResourceSerNavigation { get; set; }

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<SessionProcedurePart> SessionProcedurePart { get; set; } = new List<SessionProcedurePart>();

    [InverseProperty("RadiationSerNavigation")]
    public virtual ICollection<SliceRt> SliceRt { get; set; } = new List<SliceRt>();
}
