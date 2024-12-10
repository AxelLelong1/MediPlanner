using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ResourceEmergencyGroup
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(128)]
    public string? EmergencyGroup { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[] HstryTimeStamp { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string HstryTaskName { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("ResourceEmergencyGroup")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
