using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DiagnosisTableName", "DiagnosisCode", Name = "XIE1DiagnosisStage")]
public partial class DiagnosisStage
{
    [Key]
    public long DiagnosisStageSer { get; set; }

    [StringLength(64)]
    public string DiagnosisTableName { get; set; } = null!;

    [StringLength(16)]
    public string DiagnosisCode { get; set; } = null!;

    [Column("DiagnosisStage")]
    [StringLength(64)]
    public string? DiagnosisStage1 { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("DiagnosisStageSerNavigation")]
    public virtual ICollection<Template> Template { get; set; } = new List<Template>();
}
