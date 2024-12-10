using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivitySer", "ChecklistItemSer", Name = "XAK1ActivityChecklistItem", IsUnique = true)]
[Index("ChecklistItemSer", Name = "XIF1ActivityChecklistItem")]
public partial class ActivityChecklistItem
{
    [Key]
    public long ActivityChecklistItemSer { get; set; }

    public long ActivitySer { get; set; }

    public long ChecklistItemSer { get; set; }

    public int SortOrder { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("ActivityChecklistItem")]
    public virtual Activity ActivitySerNavigation { get; set; } = null!;

    [ForeignKey("ChecklistItemSer")]
    [InverseProperty("ActivityChecklistItem")]
    public virtual ChecklistItem ChecklistItemSerNavigation { get; set; } = null!;
}
