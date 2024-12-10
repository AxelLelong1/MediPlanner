using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Applicator
{
    [Key]
    public long AddOnSer { get; set; }

    public int AllowInserts { get; set; }

    public int RectangularFlag { get; set; }

    public double? FieldSizeX { get; set; }

    public double? FieldSizeY { get; set; }

    public double? ApplicatorLength { get; set; }

    [Column("ApplicatorDICOMType")]
    [StringLength(16)]
    public string? ApplicatorDicomtype { get; set; }

    [ForeignKey("AddOnSer")]
    [InverseProperty("Applicator")]
    public virtual AddOn AddOnSerNavigation { get; set; } = null!;

    [InverseProperty("ApplicatorSerNavigation")]
    public virtual ICollection<ApplicatorJawSize> ApplicatorJawSize { get; set; } = new List<ApplicatorJawSize>();
}
