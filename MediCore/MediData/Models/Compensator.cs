using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("AddOnMaterialSer", Name = "XIF448E_355")]
[Index("RadiationSer", Name = "XIF449Compensator")]
[Index("TrayAddOnSer", Name = "XIF450Compensator")]
public partial class Compensator
{
    [Key]
    public long CompensatorSer { get; set; }

    public long RadiationSer { get; set; }

    public long? AddOnMaterialSer { get; set; }

    public long? TrayAddOnSer { get; set; }

    [StringLength(16)]
    public string CompensatorId { get; set; } = null!;

    [StringLength(64)]
    public string? CompensatorName { get; set; }

    [StringLength(32)]
    public string CompensatorType { get; set; } = null!;

    public int AboveTrayFlag { get; set; }

    public double? FieldEdgeMargin { get; set; }

    public double? ColumnOffset { get; set; }

    public int DivergingFlag { get; set; }

    public int DicomSeqNumber { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public int Status { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? CustomCode { get; set; }

    [ForeignKey("AddOnMaterialSer")]
    [InverseProperty("Compensator")]
    public virtual AddOnMaterial? AddOnMaterialSerNavigation { get; set; }

    [InverseProperty("CompensatorSerNavigation")]
    public virtual ICollection<Matrix> Matrix { get; set; } = new List<Matrix>();

    [InverseProperty("CompensatorSerNavigation")]
    public virtual PhotonCompensator? PhotonCompensator { get; set; }

    [InverseProperty("CompensatorSerNavigation")]
    public virtual ProtonCompensator? ProtonCompensator { get; set; }

    [ForeignKey("RadiationSer")]
    [InverseProperty("Compensator")]
    public virtual ExternalFieldCommon RadiationSerNavigation { get; set; } = null!;

    [ForeignKey("TrayAddOnSer")]
    [InverseProperty("Compensator")]
    public virtual Tray? TrayAddOnSerNavigation { get; set; }
}
