using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ChartQATreatment")]
[Index("RadiationHstrySer", "ChartQaser", Name = "XAK1ChartQATreatment", IsUnique = true)]
[Index("ChartQaser", Name = "XIF794ChartQATreatment")]
public partial class ChartQatreatment
{
    [Key]
    [Column("ChartQATreatmentSer")]
    public long ChartQatreatmentSer { get; set; }

    public long RadiationHstrySer { get; set; }

    [Column("ChartQASer")]
    public long ChartQaser { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ChartQaser")]
    [InverseProperty("ChartQatreatment")]
    public virtual ChartQa ChartQaserNavigation { get; set; } = null!;

    [ForeignKey("RadiationHstrySer")]
    [InverseProperty("ChartQatreatment")]
    public virtual RadiationHstry RadiationHstrySerNavigation { get; set; } = null!;
}
