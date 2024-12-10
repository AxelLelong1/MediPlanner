using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ReportSer", Name = "XIF802ReportParameter")]
[Index("ParameterTypeSer", Name = "XIF803ReportParameter")]
public partial class ReportParameter
{
    [Key]
    public long ReportParameterSer { get; set; }

    public long ReportSer { get; set; }

    public long ParameterTypeSer { get; set; }

    public int EnabledStatus { get; set; }

    public int? EnabledDefaultFlag { get; set; }

    [StringLength(64)]
    public string ReportColumn { get; set; } = null!;

    [StringLength(64)]
    public string ParameterName1 { get; set; } = null!;

    [StringLength(64)]
    public string? ParameterName2 { get; set; }

    [StringLength(64)]
    public string? ParameterName3 { get; set; }

    [StringLength(64)]
    public string? ParameterName4 { get; set; }

    [StringLength(64)]
    public string? ParameterName5 { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ParameterTypeSer")]
    [InverseProperty("ReportParameter")]
    public virtual ParameterType ParameterTypeSerNavigation { get; set; } = null!;

    [ForeignKey("ReportSer")]
    [InverseProperty("ReportParameter")]
    public virtual Report ReportSerNavigation { get; set; } = null!;
}
