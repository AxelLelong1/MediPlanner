using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DepartmentSer", "ChecklistItemDesc", Name = "XAK1ChecklistItem", IsUnique = true)]
public partial class ChecklistItem
{
    [Key]
    public long ChecklistItemSer { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(254)]
    public string ChecklistItemDesc { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ChecklistItemSerNavigation")]
    public virtual ICollection<ActInstChecklistItem> ActInstChecklistItem { get; set; } = new List<ActInstChecklistItem>();

    [InverseProperty("ChecklistItemSerNavigation")]
    public virtual ICollection<ActivityChecklistItem> ActivityChecklistItem { get; set; } = new List<ActivityChecklistItem>();

    [InverseProperty("ChecklistItemSerNavigation")]
    public virtual ICollection<ChecklistItemGroup> ChecklistItemGroup { get; set; } = new List<ChecklistItemGroup>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ChecklistItem")]
    public virtual Department? DepartmentSerNavigation { get; set; }
}
