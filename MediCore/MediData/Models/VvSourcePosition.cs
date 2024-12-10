﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSourcePosition
{
    public long Key1 { get; set; }

    public long? Key2 { get; set; }

    public long? Key3 { get; set; }

    public long PatientSer { get; set; }

    [StringLength(16)]
    public string ObjectId { get; set; } = null!;

    [Column("InstanceUID")]
    [StringLength(64)]
    public string? InstanceUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public long SourcePositionSer { get; set; }

    public long PlanSetupSer { get; set; }

    [Column("RTPlanSer")]
    public long? RtplanSer { get; set; }
}
