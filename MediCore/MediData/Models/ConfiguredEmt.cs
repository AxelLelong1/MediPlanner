using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ConfiguredEMT")]
[Index("TechniqueSer", "EnergyModeSer", Name = "XAK1ConfiguredEMT", IsUnique = true)]
[Index("EnergyModeSer", Name = "XIF517ConfiguredEMT")]
public partial class ConfiguredEmt
{
    [Key]
    [Column("ConfiguredEMTSer")]
    public long ConfiguredEmtser { get; set; }

    public long TechniqueSer { get; set; }

    public long EnergyModeSer { get; set; }

    [Column("DefaultVirtualSADX")]
    public double? DefaultVirtualSadx { get; set; }

    [Column("DefaultVirtualSADY")]
    public double? DefaultVirtualSady { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ConfiguredEmtserNavigation")]
    public virtual ICollection<AddOnValidation> AddOnValidation { get; set; } = new List<AddOnValidation>();

    [ForeignKey("EnergyModeSer")]
    [InverseProperty("ConfiguredEmt")]
    public virtual EnergyMode EnergyModeSerNavigation { get; set; } = null!;

    [ForeignKey("TechniqueSer")]
    [InverseProperty("ConfiguredEmt")]
    public virtual Technique TechniqueSerNavigation { get; set; } = null!;
}
