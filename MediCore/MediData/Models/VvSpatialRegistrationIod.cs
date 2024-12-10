using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSpatialRegistrationIod
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string StudyId { get; set; } = null!;

    public long StudySer { get; set; }

    [Column("StudyUID")]
    [StringLength(64)]
    public string StudyUid { get; set; } = null!;

    [StringLength(16)]
    public string SeriesId { get; set; } = null!;

    [Column("SeriesUID")]
    [StringLength(64)]
    public string SeriesUid { get; set; } = null!;

    [StringLength(16)]
    public string SeriesModality { get; set; } = null!;

    [Column("SpatialRegistrationIODSer")]
    public long SpatialRegistrationIodser { get; set; }

    public long SeriesSer { get; set; }

    [Column("SpatialRegistrationIODId")]
    [StringLength(16)]
    public string SpatialRegistrationIodid { get; set; } = null!;

    [Column("SpatialRegistrationUID")]
    [StringLength(64)]
    public string SpatialRegistrationUid { get; set; } = null!;

    public int InstanceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public long? EquipmentSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(32)]
    public string RegistrationType { get; set; } = null!;

    [StringLength(254)]
    public string? FileName { get; set; }

    [StringLength(16)]
    public string? CharacterSet { get; set; }
}
