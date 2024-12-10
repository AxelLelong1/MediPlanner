using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RelatedPlanUid", "RelationshipType", Name = "IX_PlanRelationship_RelatedPlanUIDRelationshipType")]
[Index("RelationshipType", Name = "XIE1PlanRelationship")]
[Index("RtplanSer", Name = "XIF1PlanRelationship")]
[Index("RelatedRtplanSer", Name = "XIF2PlanRelationship")]
[Index("RelatedPlanSopclassSer", Name = "XIF3PlanRelationship")]
public partial class PlanRelationship
{
    [Key]
    public long PlanRelationshipSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    [Column("RelatedRTPlanSer")]
    public long? RelatedRtplanSer { get; set; }

    [Column("RelatedPlanUID")]
    [StringLength(64)]
    public string? RelatedPlanUid { get; set; }

    [Column("RelatedPlanSOPClassSer")]
    public long? RelatedPlanSopclassSer { get; set; }

    [StringLength(16)]
    public string RelationshipType { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("RelatedPlanSopclassSer")]
    [InverseProperty("PlanRelationship")]
    public virtual Sopclass? RelatedPlanSopclassSerNavigation { get; set; }

    [ForeignKey("RelatedRtplanSer")]
    [InverseProperty("PlanRelationshipRelatedRtplanSerNavigation")]
    public virtual Rtplan? RelatedRtplanSerNavigation { get; set; }

    [ForeignKey("RtplanSer")]
    [InverseProperty("PlanRelationshipRtplanSerNavigation")]
    public virtual Rtplan RtplanSerNavigation { get; set; } = null!;
}
