using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ResourceSer", "ResourceGroupSer", Name = "XAK1GroupResource", IsUnique = true)]
[Index("ResourceGroupSer", Name = "XIF243GroupResource")]
public partial class GroupResource
{
    [Key]
    public long GroupResourceSer { get; set; }

    public long ResourceSer { get; set; }

    public long ResourceGroupSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ResourceGroupSer")]
    [InverseProperty("GroupResource")]
    public virtual ResourceGroup ResourceGroupSerNavigation { get; set; } = null!;

    [ForeignKey("ResourceSer")]
    [InverseProperty("GroupResource")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
