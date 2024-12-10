using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ImagingDeviceType", Name = "XIE1ImagingDevice")]
public partial class ImagingDevice
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(30)]
    public string ImagingDeviceType { get; set; } = null!;

    [StringLength(16)]
    public string ImageModality { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    public int ConeBeamFlag { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual Ctscanner? Ctscanner { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual Ctsimulator? Ctsimulator { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual LocalizationJig? LocalizationJig { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual PortImager? PortImager { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("ImagingDevice")]
    public virtual Machine ResourceSerNavigation { get; set; } = null!;

    [InverseProperty("ResourceSerNavigation")]
    public virtual SimulationImager? SimulationImager { get; set; }

    [InverseProperty("ResourceSerNavigation")]
    public virtual VideoDigitizer? VideoDigitizer { get; set; }
}
