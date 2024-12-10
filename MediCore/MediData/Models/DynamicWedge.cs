using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class DynamicWedge
{
    [Key]
    public long AddOnSer { get; set; }

    public int EnhancedFlag { get; set; }

    public int TreatmentFlag { get; set; }

    public int BaseFlag { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("DynamicWedge")]
    public virtual Wedge AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("AddOnSerNavigation")]
    public virtual ICollection<Sttfile> Sttfile { get; set; } = new List<Sttfile>();
}
