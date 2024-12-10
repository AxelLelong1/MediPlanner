using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ImageSer", "MatchResultSer")]
[Index("MatchResultSer", Name = "XIF884ImageMatchResult")]
public partial class ImageMatchResult
{
    [Key]
    public long ImageSer { get; set; }

    [Key]
    public long MatchResultSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int ReferenceFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ImageSer")]
    [InverseProperty("ImageMatchResult")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;

    [ForeignKey("MatchResultSer")]
    [InverseProperty("ImageMatchResult")]
    public virtual MatchResult MatchResultSerNavigation { get; set; } = null!;
}
