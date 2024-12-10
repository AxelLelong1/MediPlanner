using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ContrastBolusSer", "CodeIndex", "CodeType", Name = "XAK1ContrastBolusCode", IsUnique = true)]
public partial class ContrastBolusCode
{
    [Key]
    public long ContrastBolusCodeSer { get; set; }

    public long ContrastBolusSer { get; set; }

    public int CodeType { get; set; }

    public int CodeIndex { get; set; }

    [StringLength(16)]
    public string? Value { get; set; }

    [StringLength(16)]
    public string? Designator { get; set; }

    [StringLength(16)]
    public string? Version { get; set; }

    [StringLength(64)]
    public string? Meaning { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ContrastBolusSer")]
    [InverseProperty("ContrastBolusCode")]
    public virtual ContrastBolus ContrastBolusSerNavigation { get; set; } = null!;
}
