using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimResoureGroup
{
    [StringLength(64)]
    public string ResourceGroupCode { get; set; } = null!;

    [StringLength(32)]
    public string GroupType { get; set; } = null!;

    public long? DerivedFromResourceGroupSer { get; set; }

    public int? NoEditFlag { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? WorklistType { get; set; }

    [Column("ctrResourceGroupSer")]
    public long CtrResourceGroupSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }

    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }
}
