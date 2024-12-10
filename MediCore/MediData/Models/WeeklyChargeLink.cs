using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActInstProcCodeSer", "ActivityInstanceSer", Name = "XAKWeeklyChargeLink", IsUnique = true)]
[Index("ActivityInstanceSer", Name = "XIF1015WeeklyChargeLink")]
public partial class WeeklyChargeLink
{
    [Key]
    public long WeeklyChargeLinkSer { get; set; }

    public long ActInstProcCodeSer { get; set; }

    public long ActivityInstanceSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActInstProcCodeSer")]
    [InverseProperty("WeeklyChargeLink")]
    public virtual ActInstProcCode ActInstProcCodeSerNavigation { get; set; } = null!;

    [ForeignKey("ActivityInstanceSer")]
    [InverseProperty("WeeklyChargeLink")]
    public virtual ActivityInstance ActivityInstanceSerNavigation { get; set; } = null!;
}
