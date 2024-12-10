using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HstryDateTime", Name = "IX_ActInstChecklistItem_HstryDateTime")]
[Index("ActivityInstanceSer", "ChecklistItemSer", Name = "XAK1ActInstChecklistItem", IsUnique = true)]
[Index("ChecklistItemSer", Name = "XIF2ActInstChecklistItem")]
public partial class ActInstChecklistItem
{
    [Key]
    public long ActInstChecklistItemSer { get; set; }

    public long ActivityInstanceSer { get; set; }

    public long ChecklistItemSer { get; set; }

    [StringLength(64)]
    public string? ChecklistItemResponse { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("ActInstChecklistItem")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;

    [ForeignKey("ChecklistItemSer")]
    [InverseProperty("ActInstChecklistItem")]
    public virtual ChecklistItem ChecklistItemSerNavigation { get; set; } = null!;
}
