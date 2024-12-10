using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("PatientSer", "RefPointId", Name = "XAK1RefPoint", IsUnique = true)]
[Index("RefPointUid", Name = "XAK2RefPoint", IsUnique = true)]
[Index("PatientVolumeSer", "RefPointId", Name = "XAKRefPoint", IsUnique = true)]
[Index("HstryDateTime", Name = "XIE1RefPoint")]
public partial class RefPoint
{
    [Key]
    public long RefPointSer { get; set; }

    public long PatientVolumeSer { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string RefPointId { get; set; } = null!;

    [StringLength(64)]
    public string? RefPointName { get; set; }

    [Column("RefPointUID")]
    [StringLength(64)]
    public string RefPointUid { get; set; } = null!;

    [StringLength(16)]
    public string? RefPointType { get; set; }

    public double? TotalDoseLimit { get; set; }

    public double? DailyDoseLimit { get; set; }

    public double? SessionDoseLimit { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("RefPointSerNavigation")]
    public virtual ICollection<BreakPoint> BreakPoint { get; set; } = new List<BreakPoint>();

    [InverseProperty("RefPointSerNavigation")]
    public virtual ICollection<DoseContribution> DoseContribution { get; set; } = new List<DoseContribution>();

    [ForeignKey("PatientVolumeSer")]
    [InverseProperty("RefPoint")]
    public virtual PatientVolume PatientVolumeSerNavigation { get; set; } = null!;

    [InverseProperty("RefPointSerNavigation")]
    public virtual ICollection<RadiationRefPoint> RadiationRefPoint { get; set; } = new List<RadiationRefPoint>();

    [InverseProperty("RefPointSerNavigation")]
    public virtual ICollection<RefPointHstry> RefPointHstry { get; set; } = new List<RefPointHstry>();

    [InverseProperty("RefPointSerNavigation")]
    public virtual ICollection<RefPointLocation> RefPointLocation { get; set; } = new List<RefPointLocation>();

    [InverseProperty("RefPointSerNavigation")]
    public virtual ICollection<RefPointLog> RefPointLog { get; set; } = new List<RefPointLog>();
}
