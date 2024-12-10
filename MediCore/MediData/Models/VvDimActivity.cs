using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimActivity
{
    [StringLength(64)]
    public string ActivityCode { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ActivityType { get; set; } = null!;

    public int? DefaultDuration { get; set; }

    [StringLength(16)]
    public string ActivityObjectStatus { get; set; } = null!;

    public int ActivityRevCount { get; set; }

    [Column("ctrActivitySer")]
    public long CtrActivitySer { get; set; }

    [Column("ctrActivityCategorySer")]
    public long CtrActivityCategorySer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectivceStartDate { get; set; }

    [StringLength(64)]
    public string ActivityCategoryCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOn { get; set; }

    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }
}
