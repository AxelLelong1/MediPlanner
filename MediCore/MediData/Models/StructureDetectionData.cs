using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

/// <summary>
/// The structure detection data scheme Holds data acquired on HET for a given RT Image.
/// </summary>
public partial class StructureDetectionData
{
    /// <summary>
    /// Internal Identification (Serial Number which is the non-clustered Primary Key to the Table).
    /// 	The vp_syGetNextKey procedure retrieves the key from the NextKeyTable.
    /// 	At the moment this field is just for compatibility with automatic stored procedures generator.
    /// </summary>
    [Key]
    public long StructureDetectionDataSer { get; set; }

    /// <summary>
    /// Foreign key specifying the image linked to these data.
    /// 	It is defined as unique field, since only one set per image can exist.
    /// </summary>
    public long ImageSer { get; set; }

    /// <summary>
    /// Blob of data not interpretable at database level.
    /// </summary>
    public byte[] Data { get; set; } = null!;

    [ForeignKey("ImageSer")]
    [InverseProperty("StructureDetectionData")]
    public virtual Image1 ImageSerNavigation { get; set; } = null!;
}
