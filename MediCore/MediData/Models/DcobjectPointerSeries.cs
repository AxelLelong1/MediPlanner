using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DCObjectPointerSeries")]
[Index("DcobjectPointerStudySer", Name = "XIF825DCObjectPointerSeries")]
public partial class DcobjectPointerSeries
{
    [Key]
    [Column("DCObjectPointerSeriesSer")]
    public long DcobjectPointerSeriesSer { get; set; }

    [Column("DCObjectPointerStudySer")]
    public long DcobjectPointerStudySer { get; set; }

    [StringLength(16)]
    public string? Modality { get; set; }

    [Column("SeriesUID")]
    [StringLength(64)]
    public string SeriesUid { get; set; } = null!;

    [ForeignKey("DcobjectPointerStudySer")]
    [InverseProperty("DcobjectPointerSeries")]
    public virtual DcobjectPointerStudy DcobjectPointerStudySerNavigation { get; set; } = null!;

    [InverseProperty("DcobjectPointerSeriesSerNavigation")]
    public virtual ICollection<ObjectPointer> ObjectPointer { get; set; } = new List<ObjectPointer>();
}
