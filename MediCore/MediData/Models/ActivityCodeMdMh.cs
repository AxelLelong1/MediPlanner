using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ModifierSer", "ActivityCodeMdRevCount")]
[Table("ActivityCodeMdMH")]
public partial class ActivityCodeMdMh
{
    [Key]
    public long ModifierSer { get; set; }

    [Key]
    public int ActivityCodeMdRevCount { get; set; }

    [StringLength(64)]
    public string Modifier { get; set; } = null!;

    public double? MdfrMultiplier { get; set; }

    [StringLength(64)]
    public string Description { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ModifierSer")]
    [InverseProperty("ActivityCodeMdMh")]
    public virtual ActivityCodeMd ModifierSerNavigation { get; set; } = null!;
}
