using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PrintReportSer", "ApplicationSer")]
[Index("ApplicationSer", Name = "XIF451ApplicationPrintReport")]
public partial class ApplicationPrintReport
{
    [Key]
    public long PrintReportSer { get; set; }

    [Key]
    public long ApplicationSer { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ApplicationSer")]
    [InverseProperty("ApplicationPrintReport")]
    public virtual Application ApplicationSerNavigation { get; set; } = null!;

    [ForeignKey("PrintReportSer")]
    [InverseProperty("ApplicationPrintReport")]
    public virtual PrintReport PrintReportSerNavigation { get; set; } = null!;
}
