using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("DCObjectPointerStudy")]
public partial class DcobjectPointerStudy
{
    [Key]
    [Column("DCObjectPointerStudySer")]
    public long DcobjectPointerStudySer { get; set; }

    [Column("StudyUID")]
    [StringLength(64)]
    public string StudyUid { get; set; } = null!;

    [InverseProperty("DcobjectPointerStudySerNavigation")]
    public virtual ICollection<DcobjectPointerSeries> DcobjectPointerSeries { get; set; } = new List<DcobjectPointerSeries>();
}
