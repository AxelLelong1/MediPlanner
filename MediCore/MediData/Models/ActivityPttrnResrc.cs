using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityPttrnSer", "ResourceSer")]
[Index("ResourceSer", Name = "XIF352EventPttrnScndResrc")]
public partial class ActivityPttrnResrc
{
    [Key]
    public long ActivityPttrnSer { get; set; }

    [Key]
    public long ResourceSer { get; set; }

    public int ExclusiveFlag { get; set; }

    public int PrimaryFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityPttrnSer")]
    [InverseProperty("ActivityPttrnResrc")]
    public virtual ActivityPttrn ActivityPttrnSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("ActivityPttrnResrc")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
