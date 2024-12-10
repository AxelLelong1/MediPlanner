using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Processing
{
    [Key]
    public long ProcessingSer { get; set; }

    [StringLength(16)]
    public string ProcessingId { get; set; } = null!;

    [StringLength(64)]
    public string? ProcessingName { get; set; }

    public int? RootFlag { get; set; }

    [StringLength(64)]
    public string? FunctionName { get; set; }

    public int? ProcessingStatus { get; set; }

    [StringLength(254)]
    public string? ImageTypes { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ParameterList { get; set; }

    public int ParameterListLen { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("ChildProcessingSerNavigation")]
    public virtual ICollection<ChildProcessing> ChildProcessingChildProcessingSerNavigation { get; set; } = new List<ChildProcessing>();

    [InverseProperty("ParentProcessingSerNavigation")]
    public virtual ICollection<ChildProcessing> ChildProcessingParentProcessingSerNavigation { get; set; } = new List<ChildProcessing>();

    [InverseProperty("DefaultProcessingSerNavigation")]
    public virtual ICollection<Image1> Image1DefaultProcessingSerNavigation { get; set; } = new List<Image1>();

    [InverseProperty("OtherProcessingSerNavigation")]
    public virtual ICollection<Image1> Image1OtherProcessingSerNavigation { get; set; } = new List<Image1>();
}
