using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimActInstTemplateLinkIncr
{
    public long ActivityInstanceSer { get; set; }

    [StringLength(16)]
    public string? ActivityInstanceId { get; set; }

    public long ActivityInstanceLinkSer { get; set; }

    public int? ActivityInstanceLinkRevCount { get; set; }

    public long? PredecessorSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HstryDateTime { get; set; }

    [StringLength(255)]
    public string? HstryUserName { get; set; }

    public long? TemplateCycleSer { get; set; }

    public int? TemplateCycleRevCount { get; set; }

    public long ActivitySer { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;
}
