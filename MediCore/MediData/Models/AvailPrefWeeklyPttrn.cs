using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivitySer", "ResourceDepartmentSer", "PrfrPttrnFlag", Name = "XIE1AvailPrefWeeklyPttrn")]
[Index("ActivityCategorySer", Name = "XIF1006AvailPrefWeeklyPttrn")]
[Index("ResourceDepartmentSer", Name = "XIF281NonEventPttrnType")]
public partial class AvailPrefWeeklyPttrn
{
    [Key]
    public long AvailPrefWeeklyPttrnSer { get; set; }

    public long? ActivitySer { get; set; }

    public long ResourceDepartmentSer { get; set; }

    public int PrfrPttrnFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternEndDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? ActivityCategorySer { get; set; }

    [ForeignKey("ActivityCategorySer")]
    [InverseProperty("AvailPrefWeeklyPttrn")]
    public virtual ActivityCategory? ActivityCategorySerNavigation { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("AvailPrefWeeklyPttrn")]
    public virtual Activity? ActivitySerNavigation { get; set; }

    [InverseProperty("AvailPrefWeeklyPttrnSerNavigation")]
    public virtual ICollection<AvailPrefPttrnDetails> AvailPrefPttrnDetails { get; set; } = new List<AvailPrefPttrnDetails>();

    [ForeignKey("ResourceDepartmentSer")]
    [InverseProperty("AvailPrefWeeklyPttrn")]
    public virtual ResourceDepartment ResourceDepartmentSerNavigation { get; set; } = null!;
}
