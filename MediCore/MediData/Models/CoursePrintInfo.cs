using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class CoursePrintInfo
{
    [Key]
    public long CourseSer { get; set; }

    public int? LastPrintedPageNum { get; set; }

    public int? LastPrintedLineNum { get; set; }

    [StringLength(254)]
    public string? SessionsPrintedLineNum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SummaryPrintDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientHisPrintDate { get; set; }

    [StringLength(64)]
    public string? ChartFormat { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("CourseSer")]
    [InverseProperty("CoursePrintInfo")]
    public virtual Course CourseSerNavigation { get; set; } = null!;
}
