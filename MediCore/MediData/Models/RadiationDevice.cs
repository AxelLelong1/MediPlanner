using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class RadiationDevice
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(30)]
    public string RadiationDeviceType { get; set; } = null!;

    [StringLength(64)]
    public string? Features { get; set; }

    public int CompletelyModelled { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual BrachyUnit? BrachyUnit { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ExternalBeam? ExternalBeam { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Radiation> Radiation { get; set; } = new List<Radiation>();

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<RadioactiveSource> RadioactiveSource { get; set; } = new List<RadioactiveSource>();

    [ForeignKey("ResourceSer")]
    [InverseProperty("RadiationDevice")]
    public virtual Machine ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("ResourceSerNavigation")]
    public virtual Simulator? Simulator { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual ICollection<Slot> Slot { get; set; } = new List<Slot>();

    [InverseProperty("ActualMachineSerNavigation")]
    public virtual ICollection<TreatmentRecord> TreatmentRecord { get; set; } = new List<TreatmentRecord>();
}
