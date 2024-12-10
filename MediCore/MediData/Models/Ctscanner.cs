using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("CTScanner")]
public partial class Ctscanner
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(254)]
    public string? CalibrationFile { get; set; }

    public int DefaultFlag { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Ctscanner")]
    public virtual ImagingDevice ResourceSerNavigation { get; set; } = null!;
}
