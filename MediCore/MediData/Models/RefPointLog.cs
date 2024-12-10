using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DoseCorrectionLogSer", Name = "XIF444RefPointLog")]
[Index("RefPointSer", Name = "XIF655RefPointLog")]
public partial class RefPointLog
{
    [Key]
    public long RefPointLogSer { get; set; }

    public long? DoseCorrectionLogSer { get; set; }

    public long RefPointSer { get; set; }

    [StringLength(32)]
    public string ModificationType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModificationDate { get; set; }

    public double? DoseDelta { get; set; }

    [StringLength(255)]
    public string? OvrdAuthorizedName { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DoseCorrectionLogSer")]
    [InverseProperty("RefPointLog")]
    public virtual DoseCorrectionLog? DoseCorrectionLogSerNavigation { get; set; }

    [ForeignKey("RefPointSer")]
    [InverseProperty("RefPointLog")]
    public virtual RefPoint RefPointSerNavigation { get; set; } = null!;
}
