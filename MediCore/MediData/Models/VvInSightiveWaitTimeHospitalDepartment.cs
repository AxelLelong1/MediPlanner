using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvInSightiveWaitTimeHospitalDepartment
{
    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [StringLength(64)]
    public string HospitalName { get; set; } = null!;

    [StringLength(16)]
    public string? DepartmentId { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }
}
