using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class VideoDigitizer
{
    [Key]
    public long ResourceSer { get; set; }

    public int? DefStorageRes { get; set; }

    [Column("XYAspectRatio")]
    public double? XyaspectRatio { get; set; }

    [StringLength(64)]
    public string? VideoBoard { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("VideoDigitizer")]
    public virtual ImagingDevice ResourceSerNavigation { get; set; } = null!;
}
