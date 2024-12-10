using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PrintReport
{
    [Key]
    public long PrintReportSer { get; set; }

    [Column("PrintReportID")]
    [StringLength(64)]
    public string PrintReportId { get; set; } = null!;

    [StringLength(254)]
    public string PrintReportDesc { get; set; } = null!;

    [StringLength(254)]
    public string PrintReportTemplate { get; set; } = null!;

    [Column("PrintReportSP")]
    [StringLength(64)]
    public string PrintReportSp { get; set; } = null!;

    [StringLength(254)]
    public string? PrintReportArg { get; set; }

    [StringLength(254)]
    public string PrintReportBind1 { get; set; } = null!;

    [StringLength(254)]
    public string? PrintReportBind2 { get; set; }

    public int ModeDialog1 { get; set; }

    public int ModeDialog2 { get; set; }

    public int ModeDialog3 { get; set; }

    public int ModeDialog4 { get; set; }

    public int PrintModeFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("PrintReportSerNavigation")]
    public virtual ICollection<ApplicationPrintReport> ApplicationPrintReport { get; set; } = new List<ApplicationPrintReport>();
}
