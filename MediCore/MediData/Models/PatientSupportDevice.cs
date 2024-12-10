using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PatientSupportDevice
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string PatSupportType { get; set; } = null!;

    [StringLength(16)]
    public string? PatientSupportDeviceId { get; set; }

    [StringLength(64)]
    public string? PatientSupportDeviceName { get; set; }

    [StringLength(64)]
    public string? AccessoryCode { get; set; }

    [InverseProperty("PatientSupportDeviceSerNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("PatientSupportDevice")]
    public virtual Machine ResourceSerNavigation { get; set; } = null!;
}
