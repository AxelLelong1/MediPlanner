using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyPredecessorPlanRelationship
{
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
}
