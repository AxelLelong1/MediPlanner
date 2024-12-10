using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("VolumeType1", Name = "XAKVolumeType", IsUnique = true)]
[Index("MaterialSer", Name = "XIF1VolumeType")]
public partial class VolumeType
{
    [Key]
    public long VolumeTypeSer { get; set; }

    [Column("VolumeType")]
    [StringLength(32)]
    public string VolumeType1 { get; set; } = null!;

    public long? MaterialSer { get; set; }

    [StringLength(64)]
    public string? Description { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(16)]
    public string? DicomType { get; set; }

    public int OverlapFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("MaterialSer")]
    [InverseProperty("VolumeType")]
    public virtual Material? MaterialSerNavigation { get; set; }

    [InverseProperty("VolumeTypeSerNavigation")]
    public virtual ICollection<PatientVolume> PatientVolume { get; set; } = new List<PatientVolume>();
}
