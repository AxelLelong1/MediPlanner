using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPlanRelationship
{
    public long Key1 { get; set; }

    public long? Key2 { get; set; }

    public long? Key3 { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string? ObjectId { get; set; }

    [Column("InstanceUID")]
    [StringLength(64)]
    public string? InstanceUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [Column("RelatedPlanUID")]
    [StringLength(64)]
    public string? RelatedPlanUid { get; set; }

    public long PlanRelationshipSer { get; set; }

    [Column("RTPlanSer")]
    public long RtplanSer { get; set; }

    public long PlanSetupSer { get; set; }
}
