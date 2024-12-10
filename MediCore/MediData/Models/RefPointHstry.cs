using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RefPointSer", "RadiationHstrySer", Name = "XAK1RefPointHstry", IsUnique = true)]
[Index("RadiationHstrySer", Name = "XIF223RefPointHstry")]
public partial class RefPointHstry
{
    [Key]
    public long RefPointHstrySer { get; set; }

    public long RadiationHstrySer { get; set; }

    public long RefPointSer { get; set; }

    public double? ActualDose { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("RadiationHstrySer")]
    [InverseProperty("RefPointHstry")]
    public virtual RadiationHstry RadiationHstrySerNavigation { get; set; } = null!;

    [ForeignKey("RefPointSer")]
    [InverseProperty("RefPointHstry")]
    public virtual RefPoint RefPointSerNavigation { get; set; } = null!;
}
