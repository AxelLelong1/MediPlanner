using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HolidayId", "DepartmentSer", Name = "XAK1ScheduleHoliday", IsUnique = true)]
[Index("StartDateTime", Name = "XIE1ScheduleHoliday")]
[Index("DepartmentSer", Name = "XIF467ScheduleHoliday")]
[Index("RecurrenceRuleSer", Name = "XIF677ScheduleHoliday")]
public partial class ScheduleHoliday
{
    [Key]
    public long HolidaySer { get; set; }

    public long? DepartmentSer { get; set; }

    [StringLength(16)]
    public string HolidayId { get; set; } = null!;

    [StringLength(32)]
    public string HolidayName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDateTime { get; set; }

    public long RecurrenceRuleSer { get; set; }

    public int HsptlBusShutdown { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("ScheduleHoliday")]
    public virtual Department? DepartmentSerNavigation { get; set; }

    [ForeignKey("RecurrenceRuleSer")]
    [InverseProperty("ScheduleHoliday")]
    public virtual RecurrenceRule RecurrenceRuleSerNavigation { get; set; } = null!;
}
