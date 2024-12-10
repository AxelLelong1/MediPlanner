using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityCaptureSer", Name = "XIF1017ActCaptTreatment")]
[Index("RadiationHstrySer", Name = "XIF1018ActCaptTreatment")]
public partial class ActCaptTreatment
{
    [Key]
    public long ActCaptTreatmentSer { get; set; }

    public long ActivityCaptureSer { get; set; }

    public long RadiationHstrySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityCaptureSer")]
    [InverseProperty("ActCaptTreatment")]
    public virtual ActivityCapture ActivityCaptureSerNavigation { get; set; } = null!;

    [ForeignKey("RadiationHstrySer")]
    [InverseProperty("ActCaptTreatment")]
    public virtual RadiationHstry RadiationHstrySerNavigation { get; set; } = null!;
}
