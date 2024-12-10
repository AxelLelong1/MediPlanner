using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ActivityName", "ActivityDateTime")]
public partial class ServiceControl
{
    [Key]
    [StringLength(64)]
    public string ActivityName { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ActivityDateTime { get; set; }

    [StringLength(32)]
    public string? Object { get; set; }

    [StringLength(64)]
    public string? ObjectName { get; set; }

    [StringLength(64)]
    public string? DeviceName { get; set; }

    public int? BeforeSize { get; set; }

    public int? AfterSize { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BeforeTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AfterTime { get; set; }

    public int? ErrorCode { get; set; }

    [StringLength(254)]
    public string? ErrorDescription { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
