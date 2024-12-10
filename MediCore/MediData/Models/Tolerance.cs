using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ToleranceId", Name = "XAKTolerance", IsUnique = true)]
public partial class Tolerance
{
    [Key]
    public long ToleranceSer { get; set; }

    [StringLength(16)]
    public string ToleranceId { get; set; } = null!;

    [StringLength(64)]
    public string? ToleranceName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ToleranceSerNavigation")]
    public virtual ICollection<ExternalFieldCommon> ExternalFieldCommon { get; set; } = new List<ExternalFieldCommon>();

    [InverseProperty("ToleranceSerNavigation")]
    public virtual ICollection<ExternalFieldCommonHstry> ExternalFieldCommonHstry { get; set; } = new List<ExternalFieldCommonHstry>();

    [InverseProperty("ToleranceSerNavigation")]
    public virtual ICollection<ToleranceLimit> ToleranceLimit { get; set; } = new List<ToleranceLimit>();
}
