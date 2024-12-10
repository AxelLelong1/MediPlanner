using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class BeamlineOption
{
    [Key]
    public long AddOnSer { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("BeamlineOption")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;
}
