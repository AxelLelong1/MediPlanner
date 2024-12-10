using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("CourseSer", "SessionNum", Name = "XIE1Session", IsUnique = true)]
public partial class Session
{
    [Key]
    public long SessionSer { get; set; }

    public long CourseSer { get; set; }

    public int SessionNum { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("SessionSerNavigation")]
    public virtual ICollection<ActivitySession> ActivitySession { get; set; } = new List<ActivitySession>();

    [ForeignKey("CourseSer")]
    [InverseProperty("Session")]
    public virtual Course CourseSerNavigation { get; set; } = null!;

    [InverseProperty("SessionSerNavigation")]
    public virtual ICollection<SessionProcedure> SessionProcedure { get; set; } = new List<SessionProcedure>();

    [InverseProperty("SessionSerNavigation")]
    public virtual ICollection<SessionRtplan> SessionRtplan { get; set; } = new List<SessionRtplan>();
}
