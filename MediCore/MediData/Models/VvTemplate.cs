﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvTemplate
{
    public long TemplateSer { get; set; }

    public int TemplateRevCount { get; set; }

    public long? PatientSer { get; set; }

    public long? DepartmentSer { get; set; }

    public long? DerivedFromSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("TemplateID")]
    [StringLength(64)]
    public string? TemplateId { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    public int DefaultFlag { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long? DiagnosisStageSer { get; set; }

    public long? PayorSer { get; set; }

    public long? ResourceSer { get; set; }

    public long? CourseSer { get; set; }
}
