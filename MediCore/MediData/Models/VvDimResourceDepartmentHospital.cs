using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimResourceDepartmentHospital
{
    [Column("ctrResourceDepartmentSer")]
    public long CtrResourceDepartmentSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }

    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }

    [Column("ctrResourceSer")]
    public long CtrResourceSer { get; set; }

    [StringLength(64)]
    public string? DefaultDepartmentName { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AssignedToDepartment { get; set; }

    [StringLength(32)]
    public string AccessRights { get; set; } = null!;
}
