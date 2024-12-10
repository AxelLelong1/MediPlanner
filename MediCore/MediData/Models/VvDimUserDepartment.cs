using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimUserDepartment
{
    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }

    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }

    [StringLength(255)]
    public string UserId { get; set; } = null!;

    [Column("ctrAppUserSer")]
    public long CtrAppUserSer { get; set; }

    [Column("ctrResourceDepartmentSer")]
    public long CtrResourceDepartmentSer { get; set; }

    public int AssignedToDepartment { get; set; }
}
