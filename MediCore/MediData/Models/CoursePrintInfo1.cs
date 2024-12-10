using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("CoursePrintInfo", Schema = "DWH")]
public partial class CoursePrintInfo1
{
    [Key]
    public long CourseSer { get; set; }

    public short? LastPrintedPageNum { get; set; }

    public short? LastPrintedLineNum { get; set; }

    [StringLength(254)]
    public string? SessionsPrintedLineNum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SummaryPrintDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientHstryPrintDate { get; set; }

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
    [InverseProperty("CoursePrintInfo1")]
    public virtual Course CourseSerNavigation { get; set; } = null!;
}
