using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class DicomLocation
{
    [Key]
    public long DicomLocationSer { get; set; }

    [Column("MediaFileSetID")]
    [StringLength(16)]
    public string? MediaFileSetId { get; set; }

    [Column("MediaFileSetUID")]
    [StringLength(64)]
    public string? MediaFileSetUid { get; set; }

    [Column("AETitle")]
    [StringLength(16)]
    public string? Aetitle { get; set; }

    [InverseProperty("DicomLocationSerNavigation")]
    public virtual ICollection<ObjectPointer> ObjectPointer { get; set; } = new List<ObjectPointer>();
}
