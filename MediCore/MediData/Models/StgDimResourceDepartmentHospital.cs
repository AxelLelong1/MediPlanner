using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimResourceDepartmentHospital")]
public partial class StgDimResourceDepartmentHospital
{
    public long? ResourceDepartmentSer { get; set; }
}
