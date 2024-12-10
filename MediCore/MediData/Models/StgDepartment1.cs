using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDepartment", Schema = "DWH")]
public partial class StgDepartment1
{
    public long? DepartmentSer { get; set; }
}
