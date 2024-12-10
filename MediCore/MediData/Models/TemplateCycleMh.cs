﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TemplateCycleSer", "TemplateCycleRevCount")]
[Table("TemplateCycleMH")]
public partial class TemplateCycleMh
{
    [Key]
    public long TemplateCycleSer { get; set; }

    [Key]
    public int TemplateCycleRevCount { get; set; }

    public long TemplateSer { get; set; }

    public int TemplateRevCount { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public long CycleSer { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("TemplateCycleSer")]
    [InverseProperty("TemplateCycleMh")]
    public virtual TemplateCycle TemplateCycleSerNavigation { get; set; } = null!;
}