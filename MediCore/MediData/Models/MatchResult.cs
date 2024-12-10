using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class MatchResult
{
    [Key]
    public long MatchResultSer { get; set; }

    [StringLength(16)]
    public string MatchResultId { get; set; } = null!;

    [StringLength(64)]
    public string? MatchAlgorithm { get; set; }

    [MaxLength(96)]
    public byte[]? MatchMatrix { get; set; }

    [StringLength(64)]
    public string? KindOfMatch { get; set; }

    public double? MaxErrorDist { get; set; }

    public double? AverageErrorDist { get; set; }

    public double? ScaleFactor { get; set; }

    [StringLength(254)]
    public string? ModificationLog { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("MatchResultSerNavigation")]
    public virtual ICollection<ImageMatchResult> ImageMatchResult { get; set; } = new List<ImageMatchResult>();
}
