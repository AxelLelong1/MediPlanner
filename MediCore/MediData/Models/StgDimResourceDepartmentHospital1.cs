using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimResourceDepartmentHospital", Schema = "DWH")]
public partial class StgDimResourceDepartmentHospital1
{
    public long? ResourceDepartmentSer { get; set; }
}
