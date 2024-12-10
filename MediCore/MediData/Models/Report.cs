using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DerivedFromReportSer", Name = "XIF801Report")]
[Index("AppUserSer", Name = "XIF807Report")]
public partial class Report
{
    [Key]
    public long ReportSer { get; set; }

    public long AppUserSer { get; set; }

    [StringLength(254)]
    public string ReportName { get; set; } = null!;

    public long? DerivedFromReportSer { get; set; }

    [StringLength(64)]
    public string ProcedureName { get; set; } = null!;

    [StringLength(254)]
    public string? Description { get; set; }

    [StringLength(64)]
    public string? ReportCategory { get; set; }

    [StringLength(64)]
    public string ReportAccess { get; set; } = null!;

    [StringLength(64)]
    public string ReportType { get; set; } = null!;

    [Column("FSRptFileName")]
    [StringLength(254)]
    public string FsrptFileName { get; set; } = null!;

    [Column("FSSchFileName")]
    [StringLength(254)]
    public string FsschFileName { get; set; } = null!;

    [StringLength(64)]
    public string SchemaName { get; set; } = null!;

    [StringLength(64)]
    public string ReportFileName { get; set; } = null!;

    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    public int EditFlag { get; set; }

    public int EnabledFlag { get; set; }

    [StringLength(16)]
    public string ReportVersion { get; set; } = null!;

    [StringLength(16)]
    public string SchemaVersion { get; set; } = null!;

    [StringLength(16)]
    public string ReportValidation { get; set; } = null!;

    [StringLength(16)]
    public string? DerivedFromReportVersion { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public int ProcedureDatabaseType { get; set; }

    [ForeignKey("AppUserSer")]
    [InverseProperty("Report")]
    public virtual AppUser AppUserSerNavigation { get; set; } = null!;

    [ForeignKey("DerivedFromReportSer")]
    [InverseProperty("InverseDerivedFromReportSerNavigation")]
    public virtual Report? DerivedFromReportSerNavigation { get; set; }

    [InverseProperty("DerivedFromReportSerNavigation")]
    public virtual ICollection<Report> InverseDerivedFromReportSerNavigation { get; set; } = new List<Report>();

    [InverseProperty("ReportSerNavigation")]
    public virtual ICollection<ReportLinkage> ReportLinkageReportSerNavigation { get; set; } = new List<ReportLinkage>();

    [InverseProperty("SubReportSerNavigation")]
    public virtual ICollection<ReportLinkage> ReportLinkageSubReportSerNavigation { get; set; } = new List<ReportLinkage>();

    [InverseProperty("ReportSerNavigation")]
    public virtual ICollection<ReportParameter> ReportParameter { get; set; } = new List<ReportParameter>();
}
