using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("SliceMR")]
public partial class SliceMr
{
    [Key]
    public long SliceSer { get; set; }

    [StringLength(16)]
    public string ScanningSequence { get; set; } = null!;

    [StringLength(16)]
    public string SequenceVariant { get; set; } = null!;

    [ForeignKey("SliceSer")]
    [InverseProperty("SliceMr")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
