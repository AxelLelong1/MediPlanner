using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("VolOptConstraintsSer", Name = "XIF1VolOptMatrix")]
public partial class VolOptMatrix
{
    [Key]
    public long VolOptMatrixSer { get; set; }

    public long VolOptConstraintsSer { get; set; }

    public int SizeX { get; set; }

    public int SizeY { get; set; }

    public int SizeZ { get; set; }

    public double ResX { get; set; }

    public double ResY { get; set; }

    public double ResZ { get; set; }

    [MaxLength(96)]
    public byte[] Transformation { get; set; } = null!;

    [StringLength(32)]
    public string MatrixType { get; set; } = null!;

    [StringLength(32)]
    public string MatrixDataType { get; set; } = null!;

    [StringLength(254)]
    public string MatrixDataFile { get; set; } = null!;

    public int Priority { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("VolOptConstraintsSer")]
    [InverseProperty("VolOptMatrix")]
    public virtual VolOptConstraints VolOptConstraintsSerNavigation { get; set; } = null!;
}
