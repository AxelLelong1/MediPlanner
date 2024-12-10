using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class RecurrenceRule
{
    [Key]
    public long RecurrenceRuleSer { get; set; }

    public int Frequency { get; set; }

    public int EndCondition { get; set; }

    public int? NoOfRecurrences { get; set; }

    public int? Interval { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("RecurrenceRuleSerNavigation")]
    public virtual ICollection<NonScheduledActivity> NonScheduledActivity { get; set; } = new List<NonScheduledActivity>();

    [InverseProperty("RecurrenceRuleSerNavigation")]
    public virtual ICollection<RecurrenceElement> RecurrenceElement { get; set; } = new List<RecurrenceElement>();

    [InverseProperty("RecurrenceRuleSerNavigation")]
    public virtual ICollection<ScheduleHoliday> ScheduleHoliday { get; set; } = new List<ScheduleHoliday>();

    [InverseProperty("RecurrenceRuleSerNavigation")]
    public virtual ICollection<ScheduledActivity> ScheduledActivity { get; set; } = new List<ScheduledActivity>();
}
