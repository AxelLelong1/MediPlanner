using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SliceSer", Name = "XIF990ContrastBolus")]
public partial class ContrastBolus
{
    [Key]
    public long ContrastBolusSer { get; set; }

    [StringLength(64)]
    public string? Agent { get; set; }

    [StringLength(64)]
    public string? Route { get; set; }

    public double? Volume { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StopTime { get; set; }

    public double? TotalDose { get; set; }

    [StringLength(16)]
    public string? Ingredient { get; set; }

    public double? IngredientConcentration { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long SliceSer { get; set; }

    [InverseProperty("ContrastBolusSerNavigation")]
    public virtual ICollection<ContrastBolusCode> ContrastBolusCode { get; set; } = new List<ContrastBolusCode>();

    [InverseProperty("ContrastBolusSerNavigation")]
    public virtual ICollection<ContrastFlow> ContrastFlow { get; set; } = new List<ContrastFlow>();

    [ForeignKey("SliceSer")]
    [InverseProperty("ContrastBolus")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
