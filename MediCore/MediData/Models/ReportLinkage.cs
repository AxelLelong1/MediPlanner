using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ReportSer", Name = "XIF804ReportLinkage")]
[Index("SubReportSer", Name = "XIF805ReportLinkage")]
public partial class ReportLinkage
{
    [Key]
    public long ReportLinkageSer { get; set; }

    public long ReportSer { get; set; }

    public long SubReportSer { get; set; }

    public int EnabledFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ReportSer")]
    [InverseProperty("ReportLinkageReportSerNavigation")]
    public virtual Report ReportSerNavigation { get; set; } = null!;

    [ForeignKey("SubReportSer")]
    [InverseProperty("ReportLinkageSubReportSerNavigation")]
    public virtual Report SubReportSerNavigation { get; set; } = null!;
}
