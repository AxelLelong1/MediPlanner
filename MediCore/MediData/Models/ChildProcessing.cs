using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ParentProcessingSer", "ChildProcessingSer")]
[Index("ChildProcessingSer", Name = "XIF878ChildProcessing")]
public partial class ChildProcessing
{
    [Key]
    public long ParentProcessingSer { get; set; }

    [Key]
    public long ChildProcessingSer { get; set; }

    public long? CacheKeySer { get; set; }

    public int? SequenceNumber { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ChildProcessingSer")]
    [InverseProperty("ChildProcessingChildProcessingSerNavigation")]
    public virtual Processing ChildProcessingSerNavigation { get; set; } = null!;

    [ForeignKey("ParentProcessingSer")]
    [InverseProperty("ChildProcessingParentProcessingSerNavigation")]
    public virtual Processing ParentProcessingSerNavigation { get; set; } = null!;
}
