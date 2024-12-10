using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PhotonCompensator
{
    [Key]
    public long CompensatorSer { get; set; }

    public double? IsoToPlaneDistance { get; set; }

    [ForeignKey("CompensatorSer")]
    [InverseProperty("PhotonCompensator")]
    public virtual Compensator CompensatorSerNavigation { get; set; } = null!;
}
