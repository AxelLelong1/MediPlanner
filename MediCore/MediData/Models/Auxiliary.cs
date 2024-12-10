using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AuxiliaryId", Name = "XAK1Auxiliary", IsUnique = true)]
public partial class Auxiliary
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(16)]
    public string AuxiliaryId { get; set; } = null!;

    [StringLength(64)]
    public string? AuxiliaryName { get; set; }

    [StringLength(64)]
    public string? AuxiliaryCode { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Auxiliary")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
