using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ActivityCaptureSer", Name = "XIF634Credit")]
[Index("ActInstProcCodeSer", Name = "XIF650Credit")]
public partial class Credit
{
    [Key]
    public long CreditSer { get; set; }

    public int CreditRevCount { get; set; }

    public long ActivityCaptureSer { get; set; }

    public int ActivityCaptureRevCount { get; set; }

    public long ActInstProcCodeSer { get; set; }

    public int ActInstProcCodeRevCount { get; set; }

    [StringLength(255)]
    public string? CreditedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreditedDateTime { get; set; }

    [StringLength(255)]
    public string? ExportedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExportedDateTime { get; set; }

    [StringLength(254)]
    public string? Note { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("ActInstProcCodeSer")]
    [InverseProperty("Credit")]
    public virtual ActInstProcCode ActInstProcCodeSerNavigation { get; set; } = null!;

    [ForeignKey("ActivityCaptureSer")]
    [InverseProperty("Credit")]
    public virtual ActivityCapture ActivityCaptureSerNavigation { get; set; } = null!;

    [InverseProperty("CreditSerNavigation")]
    public virtual ICollection<CreditMh> CreditMh { get; set; } = new List<CreditMh>();
}
