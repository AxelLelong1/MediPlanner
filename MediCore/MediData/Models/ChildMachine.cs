using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ChildResourceSer", "ParentResourceSer")]
[Index("ParentResourceSer", Name = "XIF728ChildMachine")]
public partial class ChildMachine
{
    [Key]
    public long ChildResourceSer { get; set; }

    [Key]
    public long ParentResourceSer { get; set; }

    public long CacheKeySer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ChildResourceSer")]
    [InverseProperty("ChildMachineChildResourceSerNavigation")]
    public virtual Machine ChildResourceSerNavigation { get; set; } = null!;

    [ForeignKey("ParentResourceSer")]
    [InverseProperty("ChildMachineParentResourceSerNavigation")]
    public virtual Machine ParentResourceSerNavigation { get; set; } = null!;
}
