using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("MessageSer", "ResourceSer")]
[Index("ResourceSer", Name = "XIF679Recipient")]
public partial class Recipient
{
    [Key]
    public long MessageSer { get; set; }

    [Key]
    public long ResourceSer { get; set; }

    public int ReadFlag { get; set; }

    public int DeletedFlag { get; set; }

    public int RepliedFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("MessageSer")]
    [InverseProperty("Recipient")]
    public virtual Message1 MessageSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("Recipient")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
