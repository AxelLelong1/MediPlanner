using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SliceSer", Name = "XIF1001SlicePortalDoseAnalysis")]
[Index("PortalDoseAnalysisSer", Name = "XIF1002SlicePortalDoseAnalysis")]
public partial class SlicePortalDoseAnalysis
{
    [Key]
    public long SlicePortalDoseAnalysisSer { get; set; }

    public long PortalDoseAnalysisSer { get; set; }

    public long SliceSer { get; set; }

    public int DoseImageRole { get; set; }

    [ForeignKey("PortalDoseAnalysisSer")]
    [InverseProperty("SlicePortalDoseAnalysis")]
    public virtual PortalDoseAnalysis PortalDoseAnalysisSerNavigation { get; set; } = null!;

    [ForeignKey("SliceSer")]
    [InverseProperty("SlicePortalDoseAnalysis")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
