using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityCategorySer", Name = "XIF1020AvailPrefPttrnDetails")]
[Index("ActivitySer", Name = "XIF1021AvailPrefPttrnDetails")]
[Index("AvailPrefWeeklyPttrnSer", Name = "XIF333AvailPrefPttrnDetails")]
public partial class AvailPrefPttrnDetails
{
    [Key]
    public long AvailPrefPttrnDetailsSer { get; set; }

    public long AvailPrefWeeklyPttrnSer { get; set; }

    public int? PatternDayOfWeek { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternEndTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? ActivityCategorySer { get; set; }

    public long? ActivitySer { get; set; }

    [ForeignKey("ActivityCategorySer")]
    [InverseProperty("AvailPrefPttrnDetails")]
    public virtual ActivityCategory? ActivityCategorySerNavigation { get; set; }

    [ForeignKey("ActivitySer")]
    [InverseProperty("AvailPrefPttrnDetails")]
    public virtual Activity? ActivitySerNavigation { get; set; }

    [ForeignKey("AvailPrefWeeklyPttrnSer")]
    [InverseProperty("AvailPrefPttrnDetails")]
    public virtual AvailPrefWeeklyPttrn AvailPrefWeeklyPttrnSerNavigation { get; set; } = null!;
}
