using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFactActivityCaptureAttributeIncr
{
    public long ActivityCaptureAttributeSer { get; set; }

    public int ActivityCaptureAttrRevCount { get; set; }

    public long ActivityCaptureSer { get; set; }

    public int ActivityCaptureRevCount { get; set; }

    public long ActivityAttributeSer { get; set; }

    public int ActivityAttributeRevCount { get; set; }

    [StringLength(254)]
    public string? AttributeValue { get; set; }

    [StringLength(16)]
    public string ActivityCaptureAttributeObjectStatus { get; set; } = null!;

    public long UserDefActAttrSer { get; set; }

    public int UserDefActAttrRevCount { get; set; }
}
