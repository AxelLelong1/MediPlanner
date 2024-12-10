using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PortalDoseAnalysis
{
    [Key]
    public long PortalDoseAnalysisSer { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [Column("XMLPortalDoseAnalysis")]
    public string XmlportalDoseAnalysis { get; set; } = null!;

    [Column("XMLPortalDoseAnalysisLen")]
    public int XmlportalDoseAnalysisLen { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PortalDoseAnalysisSerNavigation")]
    public virtual ICollection<SlicePortalDoseAnalysis> SlicePortalDoseAnalysis { get; set; } = new List<SlicePortalDoseAnalysis>();
}
