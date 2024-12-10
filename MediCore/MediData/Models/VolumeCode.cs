using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("LanguageId", "VolumeCode1", "VolumeCodeTable", Name = "XAKVolumeCode", IsUnique = true)]
[Index("MaterialSer", Name = "XIF959VolumeCode")]
public partial class VolumeCode
{
    [Key]
    public long VolumeCodeSer { get; set; }

    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [Column("VolumeCode")]
    [StringLength(16)]
    public string VolumeCode1 { get; set; } = null!;

    [StringLength(32)]
    public string VolumeCodeTable { get; set; } = null!;

    public long? MaterialSer { get; set; }

    [StringLength(254)]
    public string? Description { get; set; }

    [Column("SearchCTLow")]
    public double? SearchCtlow { get; set; }

    [Column("SearchCTHigh")]
    public double? SearchCthigh { get; set; }

    public double? SegmentLimit { get; set; }

    public double? SurfaceTension { get; set; }

    public double? RelativeSize { get; set; }

    public int? IsletSize { get; set; }

    [StringLength(32)]
    public string? DetectionAlgorithm { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [Column("EUDAlpha")]
    public double? Eudalpha { get; set; }

    [Column("TCPAlpha")]
    public double? Tcpalpha { get; set; }

    [Column("TCPBeta")]
    public double? Tcpbeta { get; set; }

    [Column("TCPGamma")]
    public double? Tcpgamma { get; set; }

    [Column("DefaultRBEProton")]
    public double? DefaultRbeproton { get; set; }

    [Column("DefaultRBEBrachy")]
    public double? DefaultRbebrachy { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("VolumeCode")]
    public virtual LanguageLookup Language { get; set; } = null!;

    [ForeignKey("MaterialSer")]
    [InverseProperty("VolumeCode")]
    public virtual Material? MaterialSerNavigation { get; set; }

    [InverseProperty("VolumeCodeSerNavigation")]
    public virtual ICollection<PatientVolume> PatientVolume { get; set; } = new List<PatientVolume>();
}
