using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DepartmentSer", "ChecklistGroupName", Name = "XAK1ChecklistGroup", IsUnique = true)]
public partial class ChecklistGroup
{
    [Key]
    public long ChecklistGroupSer { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(254)]
    public string ChecklistGroupName { get; set; } = null!;

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ChecklistGroupSerNavigation")]
    public virtual ICollection<ChecklistItemGroup> ChecklistItemGroup { get; set; } = new List<ChecklistItemGroup>();

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ChecklistGroup")]
    public virtual Department? DepartmentSerNavigation { get; set; }
}
