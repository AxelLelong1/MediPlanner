using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientDepartment
{
    [Column("ctrPatientDepartmentSer")]
    public long CtrPatientDepartmentSer { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long CtrDepartmentSer { get; set; }

    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveEndDate { get; set; }
}
