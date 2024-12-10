using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("RefPointSer", "BreakPointNum", Name = "XAKBreakPoint", IsUnique = true)]
public partial class BreakPoint
{
    [Key]
    public long BreakPointSer { get; set; }

    public long RefPointSer { get; set; }

    public int BreakPointNum { get; set; }

    public double? BreakPointDose { get; set; }

    [StringLength(64)]
    public string BreakPointCondition { get; set; } = null!;

    [StringLength(255)]
    public string? AuthorizationName { get; set; }

    [StringLength(254)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizationDate { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("RefPointSer")]
    [InverseProperty("BreakPoint")]
    public virtual RefPoint RefPointSerNavigation { get; set; } = null!;
}
