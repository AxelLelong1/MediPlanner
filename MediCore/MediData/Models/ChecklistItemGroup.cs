using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ChecklistGroupSer", "ChecklistItemSer", Name = "XAK1ChecklistItemGroup", IsUnique = true)]
[Index("ChecklistItemSer", Name = "XIF1ChecklistItemGroup")]
public partial class ChecklistItemGroup
{
    [Key]
    public long ChecklistItemGroupSer { get; set; }

    public long ChecklistItemSer { get; set; }

    public long ChecklistGroupSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ChecklistGroupSer")]
    [InverseProperty("ChecklistItemGroup")]
    public virtual ChecklistGroup ChecklistGroupSerNavigation { get; set; } = null!;

    [ForeignKey("ChecklistItemSer")]
    [InverseProperty("ChecklistItemGroup")]
    public virtual ChecklistItem ChecklistItemSerNavigation { get; set; } = null!;
}
