using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ToleranceSer", "ParameterType", Name = "XAKToleranceLimit", IsUnique = true)]
public partial class ToleranceLimit
{
    [Key]
    public long ToleranceLimitSer { get; set; }

    public long ToleranceSer { get; set; }

    [StringLength(32)]
    public string ParameterType { get; set; } = null!;

    public double? ToleranceValue { get; set; }

    [StringLength(32)]
    public string? AutoSetupLevel { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ToleranceSer")]
    [InverseProperty("ToleranceLimit")]
    public virtual Tolerance ToleranceSerNavigation { get; set; } = null!;
}
