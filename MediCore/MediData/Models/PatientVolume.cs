using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("VolumeTypeSer", Name = "XIF437PatientVolume")]
[Index("VolumeCodeSer", Name = "XIF438PatientVolume")]
[Index("PatientSer", Name = "XIF919PatientVolume")]
public partial class PatientVolume
{
    [Key]
    public long PatientVolumeSer { get; set; }

    public long VolumeTypeSer { get; set; }

    public long? VolumeCodeSer { get; set; }

    [StringLength(16)]
    public string PatientVolumeId { get; set; } = null!;

    [StringLength(64)]
    public string? PatientVolumeName { get; set; }

    public double? PrescTotalDose { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long PatientSer { get; set; }

    [ForeignKey("PatientSer")]
    [InverseProperty("PatientVolume")]
    public virtual Patient PatientSerNavigation { get; set; } = null!;

    [InverseProperty("PrimaryPtvserNavigation")]
    public virtual ICollection<PlanSetup> PlanSetup { get; set; } = new List<PlanSetup>();

    [InverseProperty("PatientVolumeSerNavigation")]
    public virtual ICollection<RefPoint> RefPoint { get; set; } = new List<RefPoint>();

    [InverseProperty("PatientVolumeSerNavigation")]
    public virtual ICollection<Structure> Structure { get; set; } = new List<Structure>();

    [ForeignKey("VolumeCodeSer")]
    [InverseProperty("PatientVolume")]
    public virtual VolumeCode? VolumeCodeSerNavigation { get; set; }

    [ForeignKey("VolumeTypeSer")]
    [InverseProperty("PatientVolume")]
    public virtual VolumeType VolumeTypeSerNavigation { get; set; } = null!;
}
